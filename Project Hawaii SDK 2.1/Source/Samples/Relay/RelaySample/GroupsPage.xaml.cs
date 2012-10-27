// -
// <copyright file="GroupsPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Hawaii;
using Microsoft.Hawaii.Relay.Client;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace RelaySampleApp
{
    /// <summary>
    /// Class for Groups page of this demo application.
    /// </summary>
    public partial class GroupsPage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the GroupsPage class.
        /// </summary>
        public GroupsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the relay context.
        /// </summary>
        private RelayContext RelayContext
        {
            get { return ((App)App.Current).RelayContext; }
        }

        /// <summary>
        /// Method will be called when the user naviagtes to this page from
        /// some other page.
        /// </summary>
        /// <param name="nea">Navigation event argument.</param>
        protected override void OnNavigatedTo(NavigationEventArgs nea)
        {
            if (this.RelayContext.Endpoint != null)
            {
                // Refresh the available groups list box.
                this.RefreshGroupsListBox();

                // Refresh the endpoint groups list box.
                this.RefreshEndpointGroupsListBox();

                this.MyEndpointLabel.Text = "My Endpoint : " + this.RelayContext.Endpoint.RegistrationId;
            }

            base.OnNavigatedTo(nea);
        }
        
        /// <summary>
        /// Create a group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            RelayService.CreateGroupAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.OnCompleteCreateGroup);
        }

        /// <summary>
        /// Callback method for creating a group.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void OnCompleteCreateGroup(GroupResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                // Add the new group into available group data object.
                this.RelayContext.Groups.Add(result.Group);

                // Refresh the list box to reflect the chages.
                this.RefreshGroupsListBox(result.Group.RegistrationId);
            }
            else
            {
                this.DisplayMessage("Creating a new group failed.", "Error");
            }
        }

        /// <summary>
        /// Delete group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // If no group items selected in the listbox, return
            string groupId = (string)this.GroupsListBox.SelectedItem;
            if (string.IsNullOrEmpty(groupId))
            {
                this.DisplayMessage("No group selected from list box.", "Error");
                return;
            }

            Group group = this.RelayContext.Groups.Find(groupId);

            if (group != null)
            {
                RelayService.DeleteGroupAsync(
                    HawaiiClient.AdmClientId, 
                    HawaiiClient.AdmClientSecret,
                    group, 
                    this.OnCompleteDeleteGroup, 
                    group);
            }
        }

        /// <summary>
        /// Callback method for deleting a group.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void OnCompleteDeleteGroup(GroupResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                // Get the group object which we passed through DeleteGroupAsync method
                Group group = (Group)result.StateObject;
                Debug.Assert(group != null, "StateObject is null");

                // Remove the group from available groups object.
                this.RelayContext.Groups.Remove(group.RegistrationId);

                // Remove the group from groups container of MyEndpoint.
                if (this.RelayContext.Endpoint.Groups.Exists(group.RegistrationId))
                {
                    this.RelayContext.Endpoint.Groups.Remove(group.RegistrationId);
                }

                // We just updated the data. Refresh it
                this.RefreshGroupsListBox();
                this.RefreshEndpointGroupsListBox();
            }
            else
            {
                this.DisplayMessage("Deleting a group  failed.", "Error");
            }
        }

        /// <summary>
        /// Joining group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void JoinGroupButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.RelayContext.Endpoint == null)
            {
                this.DisplayMessage("Create a valid end point to join this group.", "Error");
                return;
            }

            // If no group items selected in the listbox, return
            string groupId = (string)this.GroupsListBox.SelectedItem;
            if (string.IsNullOrEmpty(groupId))
            {
                this.DisplayMessage("No group is selected in the list box.", "Error");
                return;
            }

            Group group = this.RelayContext.Groups.Find(groupId);
            if (group == null)
            {
                this.DisplayMessage("No group is selected from groups list box.", "Error");
                return;
            }

            if (this.RelayContext.Endpoint.Groups.Exists(group.RegistrationId))
            {
                this.DisplayMessage("Group is already associated with this Endpoint.", "Error");
                return;
            }

            RelayService.JoinGroupAsync(
                HawaiiClient.AdmClientId, 
                HawaiiClient.AdmClientSecret, 
                this.RelayContext.Endpoint, 
                group, 
                this.OnCompleteJoinGroup, 
                group);
        }

        /// <summary>
        /// Callback method for joining a group.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void OnCompleteJoinGroup(GroupResult result)
        {
            Debug.Assert(result != null, "result is null");
            
            if (result.Status == Status.Success)
            {
                // Get the group object which we passed through DeleteGroupAsync method
                Group group = (Group)result.StateObject;
                Debug.Assert(group != null, "StateObject is null");

                this.RelayContext.Endpoint.Groups.Add(group);

                // Refresh the list box to reflect the change.
                this.RefreshEndpointGroupsListBox();

            }
            else
            {
                this.DisplayMessage("Joining group failed.", "Error");
            }
        }

        /// <summary>
        /// Leaving a group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void LeaveGroupButton_Click(object sender, RoutedEventArgs e)
        {
            // If no end point is created so far, return.
            if (this.RelayContext.Endpoint == null)
            {
                this.DisplayMessage("No active end point found.", "Error");
                return;
            }

            // If no group items selected in the listbox, return
            string groupId = (string)this.EndpointGroupsListBox.SelectedItem;
            if (string.IsNullOrEmpty(groupId))
            {
                this.DisplayMessage("No group selected from list box.", "Error");
                return;
            }

            // Get the group from the endpoint groups.
            Group groupToLeave = this.RelayContext.Endpoint.Groups.Find(groupId);
            if (groupToLeave != null)
            {
                // Call the service to disassociate the group from endpoint.
                RelayService.LeaveGroupAsync(
                    HawaiiClient.AdmClientId, 
                    HawaiiClient.AdmClientSecret,
                    this.RelayContext.Endpoint, 
                    groupToLeave, 
                    this.OnCompleteLeaveGroup, 
                    groupToLeave);
            }
            else
            {
                this.DisplayMessage("No group selected from list box.", "Error");
            }
        }

        /// <summary>
        /// Callback method for leaving a new endpoint complete.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void OnCompleteLeaveGroup(GroupResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                // Get the group object which we passed through DeleteGroupAsync method
                Group group = (Group)result.StateObject;
                Debug.Assert(group != null, "StateObject is null");

                // Remove the group from Groups container of active endpoint.
                this.RelayContext.Endpoint.Groups.Remove(group.RegistrationId);

                // Refresh the list box to reflect the change.
                this.RefreshEndpointGroupsListBox();
            }
            else
            {
                this.DisplayMessage("Leaving group(s) failed.", "Error");
            }
        }

        /// <summary>
        /// Handler to go back to previous page.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        /// <summary>
        /// Helper function for refreshing groups list box.
        /// </summary>
        private void RefreshGroupsListBox(string groupToSelect=null)
        {
            // Refresh the Available Groups list box
            this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.GroupsListBox.Items.Clear();
                       foreach (Group group in this.RelayContext.Groups)
                       {
                           this.GroupsListBox.Items.Add(group.RegistrationId);
                       }

                       // Select an item in the list box
                       int selectedIndex = -1;
                       if (!string.IsNullOrEmpty(groupToSelect))
                       {
                           selectedIndex = this.GroupsListBox.Items.IndexOf(groupToSelect);
                       }
                       else
                       {
                           selectedIndex = this.GroupsListBox.Items.Count - 1;
                       }

                       if (selectedIndex != -1)
                       {
                           this.GroupsListBox.SelectedIndex = selectedIndex;
                       }
                   });
        }

        /// <summary>
        /// Helper function for refreshing the endpoint groups list box.
        /// </summary>
        private void RefreshEndpointGroupsListBox(string groupToSelect=null)
        {
            // Refresh the EndpointGroups list box
            this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.EndpointGroupsListBox.Items.Clear();
                       foreach (Group group in this.RelayContext.Endpoint.Groups)
                       {
                           this.EndpointGroupsListBox.Items.Add(group.RegistrationId);
                       }

                       // Select an item in the list box
                       int selectedIndex = -1;
                       if (!string.IsNullOrEmpty(groupToSelect))
                       {
                           selectedIndex = this.EndpointGroupsListBox.Items.IndexOf(groupToSelect);
                       }
                       else
                       {
                           selectedIndex = this.EndpointGroupsListBox.Items.Count - 1;
                       }

                       if (selectedIndex != -1)
                       {
                           this.EndpointGroupsListBox.SelectedIndex = selectedIndex;
                       }
                   });
        }

        /// <summary>
        /// Helper function for displaying a message.
        /// </summary>
        /// <param name="message">Message to be displayed.</param>
        /// <param name="caption">Message box caption.</param>
        private void DisplayMessage(string message, string caption)
        {
            this.Dispatcher.BeginInvoke(
                    delegate
                    {
                        MessageBox.Show(message, caption, MessageBoxButton.OK);
                    });
        }
    }
}