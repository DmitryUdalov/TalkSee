// -
// <copyright file="SendMessagePage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Hawaii;
using Microsoft.Hawaii.Relay.Client;
using Microsoft.Phone.Controls;

namespace RelaySampleApp
{
    /// <summary>
    /// Send Messages page of this demo application.
    /// </summary>
    public partial class SendMessagesPage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the SendMessagesPage class.
        /// </summary>
        public SendMessagesPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the RelayContext object.
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
                // Refresh the EndpointGroups list box, coz the user might have
                // the groups.
                this.EndpointGroupsListBox.Items.Clear();
                foreach (Group group in this.RelayContext.Endpoint.Groups)
                {
                    this.EndpointGroupsListBox.Items.Add(group.RegistrationId);
                }

                // Select an item in the list box
                int selectedIndex = -1;
                selectedIndex = this.EndpointGroupsListBox.Items.Count - 1;

                if (selectedIndex != -1)
                {
                    this.EndpointGroupsListBox.SelectedIndex = selectedIndex;
                }

                this.MyEndpointLabel.Text = "My Endpoint : " + this.RelayContext.Endpoint.RegistrationId;
            }

            base.OnNavigatedTo(nea);
        }
        
        /// <summary>
        /// Send to selected group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void SendToGroupButton_Click(object sender, RoutedEventArgs e)
        {
            // If no end point is created so far, return.
            if (this.RelayContext.Endpoint == null)
            {
                this.DisplayMessage("Create a valid end point to join this group.", "Error");
                return;
            }

            // If no group items selected in the listbox, return
            string groupId = (string)this.EndpointGroupsListBox.SelectedItem;
            if (string.IsNullOrEmpty(groupId))
            {
                this.DisplayMessage("No group is selected in the list box.", "Error");
                return;
            }

            // Get the group from the endpoint groups.
            Group group = this.RelayContext.Groups.Find(groupId);
            if (group == null)
            {
                this.DisplayMessage("Selected group is not joined by endpoint.", "Error");
                return;
            }

            // Send the message.
            this.SendMessage(this.RelayContext.Endpoint, group.RegistrationId);
        }

        /// <summary>
        /// Send to all groups button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void SendToAllGroupsButton_Click(object sender, RoutedEventArgs e)
        {
            // If no end point is created so far, return.
            if (this.RelayContext.Endpoint == null)
            {
                this.DisplayMessage("Create a valid end point to join this group.", "Error");
                return;
            }

            // Collect all ids of groups of the active endpoint.
            List<string> groupIds = new List<string>();
            foreach (Group group in this.RelayContext.Endpoint.Groups)
            {
                groupIds.Add(group.RegistrationId);
            }

            // If no group is associated with the active endpoint, return
            if (groupIds.Count == 0)
            {
                this.DisplayMessage("No group(s) are associated with active endpoint", "Error");
                return;
            }
            
            // Create a comma delimited recipient ids string.
            string recipientIds = string.Join(",", groupIds.ToArray());
            Debug.Assert(!string.IsNullOrEmpty(recipientIds), "recipientIds is null");

            // Send the message.
            this.SendMessage(this.RelayContext.Endpoint, recipientIds);
        }

        /// <summary>
        /// Send to a particular endpoint/group button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void SendToIdButton_Click(object sender, RoutedEventArgs e)
        {
            // If no end point is created so far, return.
            if (this.RelayContext.Endpoint == null)
            {
                this.DisplayMessage("Create a valid end point to join this group.", "Error");
                return;
            }

            // If no end point is created so far, return.
            string recipientId = this.EndpointIdTextBox.Text;
            if (string.IsNullOrEmpty(recipientId))
            {
                this.DisplayMessage("Endpoint or Group id is empty.", "Error");
                return;
            }

            // Send the message.
            this.SendMessage(this.RelayContext.Endpoint, recipientId);
        }
        
        /// <summary>
        /// Helper method for sending message.
        /// </summary>
        /// <param name="from">Send from Endpoint.</param>
        /// <param name="recipients">Send to recipients.</param>
        private void SendMessage(Endpoint from, string recipients)
        {
            // Read the message from message content textbox control
            string messageContent = this.MessageContentTextBox.Text;

            if (string.IsNullOrEmpty(messageContent))
            {
                this.DisplayMessage("Message content is empty", "Error");
                return;
            }

            byte[] message = Encoding.Unicode.GetBytes(messageContent);
            RelayService.SendMessageAsync(
                HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, 
                from, 
                recipients, 
                message, 
                this.OnCompleteSendMessage);
        }

        /// <summary>
        /// Callback method for complete sending message.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void OnCompleteSendMessage(MessagingResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                this.DisplayMessage("Sending message to group(s) succeeded.", "Info");
            }
            else
            {
                this.DisplayMessage("Sending message to group(s) failed.", "Error");
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