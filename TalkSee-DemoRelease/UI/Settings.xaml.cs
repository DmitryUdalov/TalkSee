using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Navigation;

namespace SpeechToTextSampleApp
{
    public partial class Settings : PhoneApplicationPage
    {
        private AppSettings settings = new AppSettings();

        public Settings()
        {
            InitializeComponent();

            // Add an Application Bar that has a 'done' confirmation button and 
            // a 'cancel' button
            ApplicationBar = new ApplicationBar();
            ApplicationBar.IsMenuEnabled = true;
            ApplicationBar.IsVisible = true;
            ApplicationBar.Opacity = 1.0;

            ApplicationBarIconButton doneButton = new ApplicationBarIconButton(new Uri("Assets\\appbar.check.rest.png", UriKind.Relative));
            doneButton.Text = "done";
            doneButton.Click += new EventHandler(doneButton_Click);

            ApplicationBarIconButton cancelButton = new ApplicationBarIconButton(new Uri("Assets\\appbar.cancel.rest.png", UriKind.Relative));
            cancelButton.Text = "cancel";
            cancelButton.Click += new EventHandler(cancelButton_Click);

            ApplicationBar.Buttons.Add(doneButton);
            ApplicationBar.Buttons.Add(cancelButton);

            // Copy the current settings into the text boxes as the new values
            // entered in will not be saved until the user clicks the 'done' button.
            textBoxUsername.Text = settings.UsernameSetting;
            textBoxPort.Text = settings.PortSetting;
            //textBoxPort.Text = settings.NumberSetting;

            RadioButton radioButtonAvailable = new RadioButton();
            RadioButton radioButtonUnavailable = new RadioButton();
            radioButtonAvailable.IsChecked = true;
            radioButtonUnavailable.IsChecked = false;


        }
        /// <summary>
        /// Done button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void doneButton_Click(object sender, EventArgs e)
        {
            settings.OldUsernameSetting = settings.UsernameSetting;
            settings.UsernameSetting = textBoxUsername.Text;
            settings.OldPortSetting = settings.PortSetting;
            settings.PortSetting = textBoxPort.Text;
            settings.NumberSetting = "123-456-7890";
            if (radioButtonAvailable.IsChecked == true)
            {
                settings.OldStatusSetting = settings.StatusSetting;
                settings.StatusSetting = "available";
            }
            else
            {
                settings.OldStatusSetting = settings.StatusSetting;
                settings.StatusSetting = "unavailable";
            }
            //textBoxPort.Text;
            NavigationService.GoBack();
        }

        /// <summary>
        /// Cancel button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cancelButton_Click(object sender, EventArgs e)
        {
            NavigationService.GoBack();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs nee)
        {
            base.OnNavigatedTo(nee);
            if (settings.StatusSetting == "available")
            {
                radioButtonAvailable.IsChecked = true;
            }
            else
            {
                radioButtonUnavailable.IsChecked = true;
            }
        }
    }
}
