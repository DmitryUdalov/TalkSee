// -
// <copyright file="KeyvalueDetails.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

namespace KeyValueSampleApp
{
    using System.Windows;
    using Microsoft.Hawaii.KeyValue.Client;
    using Microsoft.Phone.Controls;

    /// <summary>
    /// Keyvalue item details page of this demo application.
    /// </summary>
    public partial class KeyvalueDetails : PhoneApplicationPage
    {
        /// <summary>
        /// Initializes a new instance of the KeyvalueDetails class.
        /// </summary>
        public KeyvalueDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the key of KeyValue item.
        /// </summary>
        private string Key
        {
            get { return this.txbKey.Text.Trim(); }
            set { this.txbKey.Text = value; }
        }

        /// <summary>
        /// Gets or sets the value of KeyValue item.
        /// </summary>
        private string Value
        {
            get { return this.txbValue.Text.Trim(); }
            set { this.txbValue.Text = value; }
        }

        /// <summary>
        /// An override method of OnNavigatedTo.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.Key = NavigationContext.QueryString["key"];
            this.Value = NavigationContext.QueryString["value"];

            if (!string.IsNullOrEmpty(this.Key))
            {
                this.txbKey.IsReadOnly = true;
                this.PageTitle.Text = "Set KeyValue";
            }
            else
            {
                this.PageTitle.Text = "Add KeyValue";
            }
        }

        /// <summary>
        /// Save button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            this.StartAsync();
            KeyValueService.SetAsync(
                HawaiiClient.AdmClientId,
                HawaiiClient.AdmClientSecret,
                new KeyValueItem[1] { new KeyValueItem() { Key = this.Key, Value = this.Value } },
                this.OnSetComplete,
                null);
        }

        /// <summary>
        /// Async callback of Set API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnSetComplete(SetResult result)
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
                    MessageBox.Show("Operation succeeded!");

                    NavigationService.GoBack();
                }
            });
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
    }
}