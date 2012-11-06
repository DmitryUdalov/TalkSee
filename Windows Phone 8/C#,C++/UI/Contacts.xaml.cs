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

namespace SpeechToTextSampleApp
{
    public partial class Contacts : PhoneApplicationPage
    {
        private AppSettings settings = new AppSettings();
        public Contacts()
        {
            InitializeComponent();

            SocketClient client = new SocketClient();
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
            client.Close();

            Loaded += new RoutedEventHandler(Contacts_Loaded);
        }

        void Contacts_Loaded(object sender, RoutedEventArgs e)
        {
            List<UserInfo> directoryList = new List<UserInfo>();
            string name = "Test";
            int port = 3459;
            int id = 1109;
            string status = "Available";
            directoryList.Add(new UserInfo(name, port, id, status));
            ContactsListBox.ItemsSource = directoryList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}
