// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Diagnostics;
using System.Text;
using System.Windows;
using Microsoft.Hawaii;
using Microsoft.Hawaii.Relay.Client;
using Microsoft.Phone.Controls;

namespace RelaySampleAppPivot
{
    /// <summary>
    /// Class for Application's main page.
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        private const string ApplicationName = "RelayTestClient";

        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            this.VerifyHawaiiIdentity();

            // Set the data context of the listbox control to the sample data
            DataContext = App.MainViewModel;
            this.Loaded += new RoutedEventHandler(this.MainPage_Loaded);
        }

        /// <summary>
        /// A delegate for setting the end point in the textbox.
        /// </summary>
        /// <param name="endPoint">A valid endpoint.</param>
        private delegate void SetEndPointLabelDelegate(Endpoint endPoint);

        /// <summary>
        /// Verify that the Hawaii identity is set correctly.
        /// </summary>
        private void VerifyHawaiiIdentity()
        {
            if (string.IsNullOrEmpty(HawaiiClient.AdmClientId) ||
                string.IsNullOrEmpty(HawaiiClient.AdmClientSecret))
            {
                MessageBox.Show("The Adm client Id or client secret is missing. Please consult the \"Project Hawaii Installation Guide\" on how to obtain credentials");
                throw new Exception("Credentials are not set, exiting application");
            }
        }

        /// <summary>
        /// Load data for the ViewModel Items.
        /// </summary>
        /// <param name="sender">Sender of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
        }

        #region Creating Endpoint
        /// <summary>
        /// CreateEndpoint button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateEndpointButton_Click(object sender, RoutedEventArgs e)
        {
            Endpoint endpoint = App.MainViewModel.RelayContext.Endpoint;

            // Check whether the active endpoint object is null. If not null, 
            // display an error message and return. That means, user has to 
            // delete the current endpoint in order to a new one.
            if (endpoint != null)
            {
                this.DisplayMessage("Endpoint is already active. Delete the current endpoint and try again.", "Create Endpoint");
                return;
            }

            // Create a new endpoint.
            RelayService.CreateEndPointAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, MainPage.ApplicationName, this.OnCompleteCreateEndPoint);
        }

        /// <summary>
        /// Callback method for creating a new endpoint.
        /// </summary>
        /// <param name="endpointResult">Result object from service.</param>
        private void OnCompleteCreateEndPoint(EndpointResult endpointResult)
        {
            Debug.Assert(endpointResult != null, "endpointResult is null");

            if (endpointResult.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       // Set the app's endpoint to endpoint newly created endpoint.
                       App.MainViewModel.RelayContext.Endpoint = endpointResult.EndPoint;
                   });
            }
            else
            {
                // Display a message box, in case of any error creating a new endpoint.
                this.DisplayMessage("Error creating a new endpoint.", "Error");
            }
        }
        #endregion Creating Endpoint

        #region Deleting Endpoint
        /// <summary>
        /// Delete Endpoint button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void DeleteEndpointButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check whether the application has an active endpoint.
                Endpoint endpoint = App.MainViewModel.RelayContext.Endpoint;
                if (endpoint == null)
                {
                    this.DisplayMessage("No active endpoint found. Create a new endpoint and try deleting.", "Error");
                    return;
                }

                // Pass the group object if this endpoint is joined a group.
                // We detach endpoint from the group before we delete it.
                Group group = null;
                if (App.MainViewModel.RelayContext.Endpoint.Groups.Count != 0)
                {
                    group = App.MainViewModel.RelayContext.Endpoint.Groups[0];
                }

                // Create a new endpoint.
                RelayService.DeleteEndPointAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, endpoint, this.OnDeleteEndPoint, group);
            }
            catch (Exception ex)
            {
                this.DisplayMessage(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Callback method for deleting an endpoint.
        /// </summary>
        /// <param name="endpointResult">Result object from service.</param>
        private void OnDeleteEndPoint(ServiceResult endpointResult)
        {
            Debug.Assert(endpointResult != null, "endpointResult is null");

            if (endpointResult.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       // If any group is already attached with this endpoint,
                       // Leave from the group first. Bye doing this, all UI controls 
                       // will be updated properly.
                       Group group = (Group)endpointResult.StateObject;
                       if (group != null)
                       {
                           App.MainViewModel.RelayContext.LeaveGroup(group);
                       }

                       // The endpoint was already deleted, set app's active endpoint to null.
                       App.MainViewModel.RelayContext.Endpoint = null;

                       // Delete the Groups as well.
                       App.MainViewModel.RelayContext.Group = null;
                       App.MainViewModel.RelayContext.GroupIdToBeJoined = string.Empty;
                   });
            }
            else
            {
                // Display a message box, in case of any error creating a new endpoint.
                this.DisplayMessage("Error deleting an endpoint.", "Error");
            }
        }
        #endregion Deleting Endpoint

        #region Creating Group
        /// <summary>
        /// Create Group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateGroupButton_Click(object sender, RoutedEventArgs e)
        {
            // Check whether any group is already created and actice.
            Group group = App.MainViewModel.RelayContext.Group;
            if (group != null)
            {
                this.DisplayMessage("Another group is active. Delete the current group and try creating new group.", "Error");
                return;
            }

            RelayService.CreateGroupAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.OnCompleteCreateGroup);
        }

        /// <summary>
        /// Callback method for creating a group.
        /// </summary>
        /// <param name="groupResult">Result object from service.</param>
        private void OnCompleteCreateGroup(GroupResult groupResult)
        {
            Debug.Assert(groupResult != null, "groupResult is null");

            if (groupResult.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       // Add the new group into available group data object.
                       App.MainViewModel.RelayContext.Group = groupResult.Group;
                       App.MainViewModel.RelayContext.GroupIdToBeJoined = groupResult.Group.RegistrationId;
                   });
            }
            else
            {
                this.DisplayMessage("Creating a new group failed.", "Error");
            }
        }
        #endregion Creating Group

        #region Deleting Group
        /// <summary>
        /// Delete Group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void DeleteGroupButton_Click(object sender, RoutedEventArgs e)
        {
            // Check whether any group is already created and actice.
            Group group = App.MainViewModel.RelayContext.Group;
            if (group == null)
            {
                this.DisplayMessage("No group is created. Creat a new group and try deleting the group.", "Error");
                return;
            }

            int joinedGroupsCount = App.MainViewModel.RelayContext.Endpoint.Groups.Count;
            if (joinedGroupsCount != 0)
            {
                this.DisplayMessage("Active endpoint is already joined another group. Leave the group and try again.", "Error");
                return;
            }

            RelayService.DeleteGroupAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, group, this.OnCompleteDeleteGroup);
        }

        /// <summary>
        /// Callback method for deleting a group.
        /// </summary>
        /// <param name="groupResult">Result object from service.</param>
        private void OnCompleteDeleteGroup(GroupResult groupResult)
        {
            Debug.Assert(groupResult != null, "groupResult is null");

            if (groupResult.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                  delegate
                  {
                      // Delete the group.
                      App.MainViewModel.RelayContext.Group = null;
                      App.MainViewModel.RelayContext.GroupIdToBeJoined = string.Empty;
                  });
            }
            else
            {
                this.DisplayMessage("Error deleting group.", "Error");
            }
        }
        #endregion Deleting Group

        #region Joining Group
        /// <summary>
        /// Join Group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void JoinGroupButton_Click(object sender, RoutedEventArgs e)
        {
            Endpoint endpoint = App.MainViewModel.RelayContext.Endpoint;
            if (endpoint == null)
            {
                this.DisplayMessage("No active endpoint found.", "Error");
                return;
            }

            int joinedGroupsCount = App.MainViewModel.RelayContext.Endpoint.Groups.Count;
            if (joinedGroupsCount != 0)
            {
                this.DisplayMessage("Active endpoint is already joined another group. Leave the group and try again.", "Error");
                return;
            }

            string groupId = string.Empty;

            if (App.MainViewModel.RelayContext.Group != null)
            {
                groupId = App.MainViewModel.RelayContext.Group.RegistrationId.ToString();
            }

            if (string.IsNullOrEmpty(groupId))
            {
                this.DisplayMessage("No group id entered. Enter a valid group id and try again.", "Error");
                return;
            }

            // Create a new group object.
            Group group = new Group()
            {
                Name = string.Empty,
                RegistrationId = groupId,
                SecretKey = string.Empty
            };

            RelayService.JoinGroupAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, endpoint, group, this.OnCompleteJoinGroup, group);
        }

        /// <summary>
        /// Callback method for joining a group.
        /// </summary>
        /// <param name="groupResult">Result object from service.</param>
        private void OnCompleteJoinGroup(GroupResult groupResult)
        {
            Debug.Assert(groupResult != null, "groupResult is null");

            if (groupResult.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                  delegate
                  {
                      Debug.Assert(App.MainViewModel.RelayContext.Endpoint != null, "endpoint is null");

                      // Get the group object from StateObject
                      Group group = (Group)groupResult.StateObject;
                      Debug.Assert(group != null, "StateObject is null");

                      // Add the new group into available group data object.
                      App.MainViewModel.RelayContext.JoinGroup(group);
                  });
            }
            else
            {
                this.DisplayMessage("Joining group is failed.", "Error");
            }
        }
        #endregion Joining Group

        #region Leaving Group
        /// <summary>
        /// Leave Group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void LeaveGroupButton_Click(object sender, RoutedEventArgs e)
        {
            Endpoint endpoint = App.MainViewModel.RelayContext.Endpoint;
            if (endpoint == null)
            {
                this.DisplayMessage("No active endpoint is found.", "Error");
                return;
            }

            int joinedGroups = App.MainViewModel.RelayContext.Endpoint.Groups.Count;
            if (joinedGroups == 0)
            {
                this.DisplayMessage("Active endpoint is not joined to current group.", "Error");
                return;
            }

            string groupId = string.Empty;

            if (App.MainViewModel.RelayContext.Group != null)
            {
                groupId = App.MainViewModel.RelayContext.Group.RegistrationId.ToString();
            }

            if (string.IsNullOrEmpty(groupId))
            {
                this.DisplayMessage("No group id is entered. Enter a valid group id and try again.", "Error");
                return;
            }

            // Create a group object.
            Group group = new Group()
            {
                Name = string.Empty,
                RegistrationId = groupId,
                SecretKey = string.Empty
            };

            RelayService.LeaveGroupAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, endpoint, group, this.OnCompleteLeaveGroup, group);
        }

        /// <summary>
        /// Callback method for leaving a group.
        /// </summary>
        /// <param name="groupResult">Result object from service.</param>
        private void OnCompleteLeaveGroup(GroupResult groupResult)
        {
            Debug.Assert(groupResult != null, "groupResult is null");

            if (groupResult.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                  delegate
                  {
                      // Get the group object from StateObject
                      Group group = (Group)groupResult.StateObject;
                      Debug.Assert(group != null, "StateObject is null");

                      // Add the new group into available group data object.
                      App.MainViewModel.RelayContext.LeaveGroup(group);
                  });
            }
            else
            {
                this.DisplayMessage("Leaving a group is failed.", "Error");
            }
        }
        #endregion Leaving Group

        #region Sending Message
        /// <summary>
        /// Send message button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            Endpoint endpoint = App.MainViewModel.RelayContext.Endpoint;
            if (endpoint == null)
            {
                this.DisplayMessage("No active endpoint found.", "Error");
                return;
            }

            string recipients = App.MainViewModel.RelayContext.Recipients;
            if (string.IsNullOrEmpty(recipients))
            {
                this.DisplayMessage("No Recipient id entered.", "Error");
                return;
            }

            string messageContent = App.MainViewModel.RelayContext.MessageContent;
            if (string.IsNullOrEmpty(messageContent))
            {
                this.DisplayMessage("Message content is empty", "Error");
                return;
            }

            byte[] message = Encoding.Unicode.GetBytes(messageContent);
            RelayService.SendMessageAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, endpoint, recipients, message, this.OnCompleteSendMessage);
        }

        /// <summary>
        /// Callback method for complete sending message.
        /// </summary>
        /// <param name="messagingResult">Result object from service.</param>
        private void OnCompleteSendMessage(MessagingResult messagingResult)
        {
            Debug.Assert(messagingResult != null, "messagingResult is null");

            if (messagingResult.Status == Status.Error)
            {
                this.DisplayMessage("Sending message to group(s) failed.", "Error");
            }
        }
        #endregion Sending Message

        #region Receiving Messages
        /// <summary>
        /// Receive message button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void ReceiveMessagesButton_Click(object sender, RoutedEventArgs e)
        {
            Endpoint endpoint = App.MainViewModel.RelayContext.Endpoint;
            if (endpoint == null)
            {
                this.DisplayMessage("No active endpoint available.", "Error");
                return;
            }

            RelayService.ReceiveMessagesAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, endpoint, string.Empty, this.ReceiveMessages);
        }

        /// <summary>
        /// Callback method for receiving messages.
        /// </summary>
        /// <param name="messagingResult">Result object from service.</param>
        private void ReceiveMessages(MessagingResult messagingResult)
        {
            Debug.Assert(messagingResult != null, "messagingResult is null");

            if (messagingResult.Status == Status.Success)
            {
                if (messagingResult.Messages == null || messagingResult.Messages.Count == 0)
                {
                    this.Dispatcher.BeginInvoke(
                    delegate
                    {
                        MessageBox.Show("No messages available.", "Info", MessageBoxButton.OK);
                    });
                    return;
                }
                else
                {
                    this.Dispatcher.BeginInvoke(
                    delegate
                    {
                        App.MainViewModel.RelayContext.Messages.Clear();
                        messagingResult.Messages.ForEach((item) => App.MainViewModel.RelayContext.Messages.Add(item));
                    });
                }
            }
            else
            {
                this.DisplayMessage("Error receiving messages.", "Error");
                return;
            }
        }
        #endregion Receiving Messages

        /// <summary>
        /// Clear message button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void ClearMessagesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       App.MainViewModel.RelayContext.Messages.Clear();
                   });
        }

        /// <summary>
        /// Helper method to display messages.
        /// </summary>
        /// <param name="message">A valid message.</param>
        /// <param name="caption">A valid caption.</param>
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