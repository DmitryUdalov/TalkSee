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

using System.Diagnostics;
using PhoneVoIPApp.UI;

namespace SpeechToTextSampleApp
{
    public partial class Contacts : PhoneApplicationPage
    {
        private AppSettings settings = new AppSettings();
        public Contacts()
        {
            InitializeComponent();

            /*SocketClient client = new SocketClient();
            client.Connect("lore.cs.purdue.edu", 3459);
            string add;
            if (settings.PortSetting != null && settings.UsernameSetting != null)
            {
                add = "ADD " + settings.UsernameSetting + " " + settings.PortSetting + "\n";
            }
            else
            {
                add = "ADD default default\n";
            }
            client.Send(add);
            string result = client.Receive();
            //char[] delimiterChars = { ' ' };
            //string[] words = result.Split(delimiterChars);
            //Debug.WriteLine(words[0]);
            //Debug.WriteLine(words[1]);
            client.Close();*/

            Loaded += new RoutedEventHandler(Contacts_Loaded);
        }

        void Contacts_Loaded(object sender, RoutedEventArgs e)
        {
            List<UserInfo> directoryList = new List<UserInfo>();
            /*string name = "Test";
            int port = 3459;
            int id = 1109;
            string status = "Available";*/
            directoryList.Add(new UserInfo("Aaron Petry", "708-566-0506", 5605, "Available"));
            directoryList.Add(new UserInfo("Ashley Braun", "260-413-1275", 1109, "Busy"));
            directoryList.Add(new UserInfo("Chris Bauschka", "574-850-4624", 4264, "Away"));
            directoryList.Add(new UserInfo("Mark Higa", "951-500-5190", 9150, "Available"));
            ContactsListBox.ItemsSource = directoryList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button source = (Button)e.OriginalSource;
            UserInfo selectedUser = (UserInfo)source.DataContext;
            GlobalVariables.selectedUser = selectedUser;
            NavigationService.Navigate(new Uri("/OutgoingCallPage.xaml", UriKind.Relative));
        }

        private void STT_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/STTPage.xaml", UriKind.Relative));
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }


        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Help.xaml", UriKind.Relative));
        }

        private void SimulateIncomingCallButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/IncomingCallPage.xaml", UriKind.Relative));
        }
    }
}
