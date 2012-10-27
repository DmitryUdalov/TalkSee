// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Hawaii;
using Microsoft.Hawaii.Rendezvous.Client;
using Microsoft.Phone.Controls;

namespace RendezvousSampleApp
{
    /// <summary>
    /// Main page class.
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            this.VerifyHawaiiIdentity();

            this.DataContext = App.MainPageViewModel;
            this.Loaded += new RoutedEventHandler(this.MainPage_Loaded);

        }

        /// <summary>
        /// Gets or sets the name registration context.
        /// </summary>
        private NameRegistrationContext NameRegistrationContext
        {
            get { return App.MainPageViewModel.NameRegistrationContext; }
            set { App.MainPageViewModel.NameRegistrationContext = value; }
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
        /// Main page loaded event handler.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.MainPageViewModel.IsDataLoaded)
            {
                App.MainPageViewModel.LoadData();
            }
        }

        /// <summary>
        /// Register name button event handler.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void RegisterNameButton_Click(object sender, RoutedEventArgs e)
        {
            string name = this.NameTextBox.Text;

            if (!string.IsNullOrEmpty(name))
            {
                RendezvousService.RegisterNameAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, name, this.OnCompleteRegisterName, null);
            }
            else
            {
                this.DisplayMessage("Invalid name found. Enter a name and try again.", "Error");
            }
        }

        /// <summary>
        /// Register name on complete call back.
        /// </summary>
        /// <param name="result">Name registration service result.</param>
        private void OnCompleteRegisterName(NameRegistrationResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.NameRegistrationContext = new NameRegistrationContext(result.NameRegistration);

                       // Store the secret key in isolated storage.
                       RendezvousStorage.SetSecretKey(result.NameRegistration.Name, result.NameRegistration.SecretKey);
                   });
            }
            else
            {
                this.DisplayMessage("Name registration failed.", "Error");
            }
        }

        /// <summary>
        /// Unregister name button event handler.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void UnregisterNameButton_Click(object sender, RoutedEventArgs e)
        {
            string name = this.NameTextBox.Text;
            if (!string.IsNullOrEmpty(name))
            {
                string secretKey = RendezvousStorage.GetSecretKey(name);
                if (string.IsNullOrEmpty(secretKey))
                {
                    this.DisplayMessage("You are not the owner of this name or the name ownership details are lost. You can't perform this operation.", "Error");
                    return;
                }

                NameRegistration nameRegistration = new NameRegistration()
                {
                    Name = name,
                    SecretKey = secretKey
                };

                RendezvousService.UnregisterNameAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, nameRegistration, this.OnCompleteUnregisterName, null);
            }
            else
            {
                this.DisplayMessage("Invalid name found. Enter a name and try again.", "Error");
            }
        }

        /// <summary>
        /// Unregister name on complete call back.
        /// </summary>
        /// <param name="result">Name registration service result.</param>
        private void OnCompleteUnregisterName(NameRegistrationResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.NameRegistrationContext.SetEmpty();
                   });
            }
            else
            {
                this.DisplayMessage("Deleting a name registration failed.", "Error");
            }
        }

        /// <summary>
        /// Associate id button event handler.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void AssociateIdButton_Click(object sender, RoutedEventArgs e)
        {
            string name = this.NameTextBox.Text;
            string registrationId = this.RegistrationIdTextBox.Text;

            if (!string.IsNullOrEmpty(name) ||
                !string.IsNullOrEmpty(registrationId))
            {
                string secretKey = RendezvousStorage.GetSecretKey(name);
                if (string.IsNullOrEmpty(secretKey))
                {
                    this.DisplayMessage("You are not the owner of this name or the name ownership details are lost. You can't perform this operation.", "Error");
                    return;
                }

                NameRegistration nameRegistration = new NameRegistration()
                {
                    Name = name,
                    Id = registrationId,
                    SecretKey = secretKey
                };

                RendezvousService.AssociateIdAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, nameRegistration, this.OnCompleteAssociateId, nameRegistration);
            }
            else
            {
                this.DisplayMessage("Invalid registration name/id found. Enter a name and registration id and try again.", "Error");
            }
        }

        /// <summary>
        /// Associate id on complete call back.
        /// </summary>
        /// <param name="result">Name registration service result.</param>
        private void OnCompleteAssociateId(NameRegistrationResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                NameRegistration nameRegistration = (NameRegistration)result.StateObject;
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.NameRegistrationContext = new NameRegistrationContext(nameRegistration);
                   });
            }
            else
            {
                this.DisplayMessage("Associating a registration id with a name failed.", "Error");
            }
        }

        /// <summary>
        /// Disassociate id button event handler.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event arguments.</param>
        private void DisassociateIdButton_Click(object sender, RoutedEventArgs e)
        {
            string name = this.NameTextBox.Text;
            string registrationId = this.RegistrationIdTextBox.Text;

            if (!string.IsNullOrEmpty(name) ||
                !string.IsNullOrEmpty(registrationId))
            {
                string secretKey = RendezvousStorage.GetSecretKey(name);
                if (string.IsNullOrEmpty(secretKey))
                {
                    this.DisplayMessage("You are not the owner of this name or the name ownership details are lost. You can't perform this operation.", "Error");
                    return;
                }

                NameRegistration nameRegistration = new NameRegistration()
                {
                    Name = name,
                    Id = registrationId,
                    SecretKey = secretKey
                };

                RendezvousService.DisassociateIdAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, nameRegistration, this.OnCompleteDisassociateId, nameRegistration);
            }
            else
            {
                this.DisplayMessage("Invalid registration name/id found. Enter a name and registration id and try again.", "Error");
            }
        }

        /// <summary>
        /// Disassociate id on complete call back.
        /// </summary>
        /// <param name="result">Name registration service result.</param>
        private void OnCompleteDisassociateId(NameRegistrationResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                NameRegistration nameRegistration = (NameRegistration)result.StateObject;
                nameRegistration.Id = string.Empty;
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.NameRegistrationContext = new NameRegistrationContext(nameRegistration);
                   });
            }
            else
            {
                this.DisplayMessage("Disassociating a registration id from a name failed.", "Error");
            }
        }

        /// <summary>
        /// Look up name button event handler.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="ea">The parameter is not used.</param>
        private void LookupNameButton_Click(object sender, RoutedEventArgs ea)
        {
            string name = this.NameTextBox.Text;

            if (!string.IsNullOrEmpty(name))
            {
                RendezvousService.LookupNameAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, name, this.OnCompleteLookupName);
            }
            else
            {
                this.DisplayMessage("Invalid name found. Enter a name and try again.", "Error");
            }
        }

        /// <summary>
        /// Performs name resolution and updates the UI accordingly.
        /// </summary>
        /// <remarks>
        /// This routine may block inside of the NameRegistrtion.Lookup
        /// method, so it is typically called on a worker thread.
        /// </remarks>
        /// <param name="result">Name registration service result.</param>
        private void OnCompleteLookupName(NameRegistrationResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                this.Dispatcher.BeginInvoke(
                   delegate
                   {
                       this.NameRegistrationContext = new NameRegistrationContext(result.NameRegistration);
                   });
            }
            else
            {
                this.DisplayMessage("Name lookup failed.", "Error");
            }
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