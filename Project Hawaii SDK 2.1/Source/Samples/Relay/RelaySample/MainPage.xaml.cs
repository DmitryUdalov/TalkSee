// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Collections.Generic;
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
    /// MainPage of this demo application.
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
        }

        /// <summary>
        /// Gets the relay data context.
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
            if (String.IsNullOrEmpty(HawaiiClient.AdmClientId) || 
                String.IsNullOrEmpty(HawaiiClient.AdmClientSecret))
            {
                return;
            }

            if (this.RelayContext.Endpoint != null)
            {
                this.MyEndpointLabel.Text = "My Endpoint : " + this.RelayContext.Endpoint.RegistrationId;

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
            }

            base.OnNavigatedTo(nea);
        }

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
        /// CreateEndpoint button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void CreateEndpointButton_Click(object sender, RoutedEventArgs e)
        {
            // Check whether the active endpoint object is null. If null, create a 
            // new end point. If not null, delete the existing one and recreate another
            // new end point.
            if (this.RelayContext.Endpoint != null)
            {
                // Delete the active endpoint.
                RelayService.DeleteEndPointAsync(
                    HawaiiClient.AdmClientId, 
                    HawaiiClient.AdmClientSecret, 
                    this.RelayContext.Endpoint, 
                    null);

                // Clear the created groups which were restored from storage.
                this.RelayContext.Groups.Clear();

                // Clear the items from list box.
                this.EndpointGroupsListBox.Items.Clear();
            }

            // Create a new endpoint.
            RelayService.CreateEndPointAsync(
                HawaiiClient.AdmClientId, 
                HawaiiClient.AdmClientSecret, 
                MainPage.ApplicationName, 
                this.OnCompleteCreateEndPoint);
        }

        /// <summary>
        /// Callback method for creating a new endpoint.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void OnCompleteCreateEndPoint(EndpointResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                // Set the newly created endpoint available in result as active(my) endpoint.
                this.RelayContext.Endpoint = result.EndPoint;

                this.Dispatcher.BeginInvoke(
                    delegate
                    {
                        this.MyEndpointLabel.Text = "My Endpoint : " + result.EndPoint.RegistrationId;
                    });
            }
            else
            {
                // Display a message box, in case of any error creating a new endpoint.
                this.DisplayMessage("Error creating a new endpoint.", "Error");
            }
        }
        
        /// <summary>
        /// ManageGroups button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void ManageGroupsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/GroupsPage.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Send message button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/SendMessagesPage.xaml", UriKind.Relative));
        }

        /// <summary>
        /// Receive Messages button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void ReceiveMessagesButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/ReceiveMessagesPage.xaml", UriKind.Relative));
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
