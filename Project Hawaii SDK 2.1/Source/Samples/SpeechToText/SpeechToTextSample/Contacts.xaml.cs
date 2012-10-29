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

        public Contacts()
        {
            InitializeComponent();
            
            SocketClient client = new SocketClient();
            client.Connect("lore.cs.purdue.edu", 3459);
            client.Send("ADD test\n");
            string result = client.Receive();
            Debug.WriteLine(result);
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
