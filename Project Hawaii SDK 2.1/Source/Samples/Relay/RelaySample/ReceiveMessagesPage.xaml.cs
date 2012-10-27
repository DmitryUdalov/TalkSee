// -
// <copyright file="ReceiveMessagesPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

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
    /// Receive Messages page of this demo application.
    /// </summary>
    public partial class ReceiveMessagesPage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the ReceiveMessagesPage class.
        /// </summary>
        public ReceiveMessagesPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A delegate for displaying messages.
        /// </summary>
        private delegate void DisplayMessagesDelegate();

        /// <summary>
        /// Gets the Relay context.
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
                if (this.RelayContext.Endpoint == null)
                {
                    MessageBox.Show("No endpoint is created.", "Error", MessageBoxButton.OK);
                }
                else
                {
                    this.Dispatcher.BeginInvoke(new DisplayMessagesDelegate(this.DisplayMessages));
                    RelayService.ReceiveMessagesAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.RelayContext.Endpoint, string.Empty, this.ReceiveMessages);
                }
            }

            base.OnNavigatedTo(nea);
        }

        /// <summary>
        /// Callback method for receiving messages for active endpoint.
        /// </summary>
        /// <param name="result">Result object from service.</param>
        private void ReceiveMessages(MessagingResult result)
        {
            Debug.Assert(result != null, "result is null");
            if (result.Status == Status.Success)
            {
                if (result.Messages == null || result.Messages.Count == 0)
                {
                    this.DisplayMessage("No new messages available.", "Info");
                }
                else
                {
                    foreach (Message message in result.Messages)
                    {
                        this.RelayContext.Messages.Add(message);
                    }

                    this.Dispatcher.BeginInvoke(new DisplayMessagesDelegate(this.DisplayMessages));
                }
            }
            else
            {
                this.DisplayMessage("Error receiving messages for active endpoint.", "Error");
            }
        }

        /// <summary>
        /// Callback method for displaying messages.
        /// </summary>
        private void DisplayMessages()
        {
            Debug.Assert(this.RelayContext.Messages != null, "Messages is null");

            this.TotalMessagesText.Text = "Total Messages: " + this.RelayContext.Messages.Count.ToString();
            this.MessagesListBox.Items.Clear();

            foreach (Message message in this.RelayContext.Messages)
            {
                StringBuilder text = new StringBuilder();
                text.Append("From: ");
                text.AppendLine(message.From);
                text.Append("To: ");
                text.AppendLine(message.To);
                text.Append(Encoding.Unicode.GetString(message.Body, 0, message.Body.Length));
                text.AppendLine();
                this.MessagesListBox.Items.Add(text.ToString());
            }
        }

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
                       this.RelayContext.Messages.Clear();
                       this.MessagesListBox.Items.Clear();
                       this.TotalMessagesText.Text = "Total Messages: 0";
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

        /// <summary>
        /// Handler to go back to previous page.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}