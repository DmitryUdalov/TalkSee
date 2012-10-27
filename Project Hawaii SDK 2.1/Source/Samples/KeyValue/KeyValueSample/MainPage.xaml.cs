// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

namespace KeyValueSampleApp
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using Microsoft.Hawaii.KeyValue.Client;
    using Microsoft.Phone.Controls;

    /// <summary>
    /// MainPage of this demo application.
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            this.VerifyHawaiiIdentity();
        }

        /// <summary>
        /// An override method of OnNavigatedTo.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.SearchByKeyPrefix();
        }

        #region Page Events
        /// <summary>
        /// Search button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            this.StartAsync();

            this.SearchByKeyPrefix();
        }

        /// <summary>
        /// Create button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/KeyvalueDetails.xaml?key=&value="), UriKind.Relative));
        }

        /// <summary>
        /// Listbox selection changed handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void LbKeys_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = this.lbKeys.SelectedValue as KeyValueItem;
            if (item != null)
            {
                NavigationService.Navigate(new Uri(string.Format("/KeyvalueDetails.xaml?key={0}&value={1}", item.Key, item.Value), UriKind.Relative));
            }
        }

        /// <summary>
        /// Create Delete click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            this.StartAsync();
            KeyValueService.DeleteByKeysAsync(
                HawaiiClient.AdmClientId,
                HawaiiClient.AdmClientSecret,
                new string[1] { (string)(sender as MenuItem).Tag },
                this.OnDeleteComplete,
                null);
        }
        #endregion Page Events

        #region Async CallBack
        /// <summary>
        /// Async callback of Get API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnGetComplete(GetResult result)
        {
            Dispatcher.BeginInvoke(() =>
            {
                this.EndAsync();
                if (result.Status != Microsoft.Hawaii.Status.Success)
                {
                    MessageBox.Show(result.Exception.Message);
                }
                else
                {
                    this.lbKeys.ItemsSource = result.KeyValueCollection;
                }
            });
        }

        /// <summary>
        /// Async callback of Delete API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnDeleteComplete(DeleteResult result)
        {
            Dispatcher.BeginInvoke(() =>
            {
                if (result.Status != Microsoft.Hawaii.Status.Success)
                {
                    this.EndAsync();
                    MessageBox.Show(result.Exception.Message);
                }
                else
                {
                    MessageBox.Show("Operation succeeded!");

                    this.SearchByKeyPrefix();
                }
            });
        }
        #endregion 

        #region Help method

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
        /// Help method to set the page into async call mode.
        /// </summary>
        private void StartAsync()
        {
            this.Opacity = 0.7;
            this.IsEnabled = false;
            this.progressBar.Visibility = System.Windows.Visibility.Visible;
        }

        /// <summary>
        /// Help method to set the page into none async call mode.
        /// </summary>
        private void EndAsync()
        {
            this.Opacity = 1;
            this.IsEnabled = true;
            this.progressBar.Visibility = System.Windows.Visibility.Collapsed;
        }

        /// <summary>
        /// Call KVS Get API.
        /// </summary>
        private void SearchByKeyPrefix()
        {
            this.StartAsync();

            KeyValueService.GetAsync(
                HawaiiClient.AdmClientId,
                HawaiiClient.AdmClientSecret,
                this.tbKeysSearch.Text.Trim(),
                1000,
                string.Empty,
                this.OnGetComplete,
                null);
        }
        #endregion Help method
    }
}