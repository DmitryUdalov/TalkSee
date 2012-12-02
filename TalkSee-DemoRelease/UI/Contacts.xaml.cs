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
using System.Windows.Navigation;
using System.Windows.Threading;
using System.Text.RegularExpressions;

namespace SpeechToTextSampleApp
{

    public partial class Contacts : PhoneApplicationPage
    {
        private AppSettings settings = new AppSettings();
        List<UserInfo> directoryList = new List<UserInfo>();
        SocketClient client;
        DispatcherTimer AudioTimer = new DispatcherTimer();
        int refreshCount = 0;
        
        public Contacts()
        {
            InitializeComponent();
            LoadContacts();
            
        }

        

        protected override void OnNavigatedTo(NavigationEventArgs nee)
        {
            base.OnNavigatedTo(nee);

	    // autorefresh every 30 seconds
            AudioTimer.Tick += AudioTimer_Tick;
            AudioTimer.Interval = TimeSpan.FromSeconds(30);
            AudioTimer.Start();

            //if (refreshCount == 0)
            //{
              //  refreshCount = 1;
                
            //}
        }

        protected override void OnNavigatedFrom(NavigationEventArgs nee)
        {
            base.OnNavigatedTo(nee);
	    // stop timer when leaving page
            AudioTimer.Stop();
        }

        private void LoadContacts()
        {
	    // create a TCP socket and connect to lore
            client = new SocketClient();
            client.Connect("lore.cs.purdue.edu", Convert.ToInt32(settings.PortSetting));
	    // remove old name
            client.Send("REMOVE " + settings.OldUsernameSetting + " " + settings.NumberSetting + " " + settings.OldStatusSetting + " " + settings.TimeStampSetting + "\n");
            string res = client.Receive();

            client.Close();

            client = new SocketClient();
            client.Connect("lore.cs.purdue.edu", Convert.ToInt32(settings.PortSetting));
	    // add new name and data
            client.Send("ADD " + settings.UsernameSetting + " " + settings.NumberSetting + " " + settings.StatusSetting + "\n");

            string result = client.Receive();
            directoryList.Clear();
            Debug.WriteLine("RESULT: " + result);
            if (result != null && result != "NotConnected")
            {
                GlobalVariables.isConnected = true;
                ContactsViewModel cvm = new ContactsViewModel();
                cvm.UpdateConnectionState("dummy");
                //TextBlock DisabledConnectionText = new TextBlock();
                //DisabledConnectionText.Text = "asdf";
                
		// The message from the Directory Server is delimited with spaces and '.
                char[] delimiterChars = { '\'' };
                string[] words = result.Split(delimiterChars);
                Debug.WriteLine("first level: " + words[0]);
                //Debug.WriteLine("first level: " + words[1]);

                char[] delimChars = { ' ' };
                string[] user;
                int j = 0;
                foreach (string i in words)
                {
		    // skip the space between quotes
                    if (j % 2 != 0)
                    {
                        //Debug.WriteLine("users: " + i);
                        //Debug.WriteLine(i.Length);
                        if (i.Length < 5)
                        {

                        }
                        else
                        {
                            //Debug.WriteLine("here");
                            user = i.Split(delimChars);

                            Debug.WriteLine("second level: " + user[0]);

                            if (user[0] != "")
                            {

				// don't display yourself
                                if (!user[0].Equals(settings.UsernameSetting))
                                {
                                    directoryList.Add(new UserInfo(user[0], user[1], 1234, user[2]));
                                    
                                }
                                if (user[0].Equals(settings.UsernameSetting))
                                {
                                    Debug.WriteLine("TIMESTAMP: " + user[3]);
                                    settings.TimeStampSetting = user[3];
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    j = j + 1;
                };
                //ContactsListBox.ItemsSource = directoryList;
            }
            else if (result.Equals("NotConnected"))
            {
                //Button 
                //    RefreshButton.text = "Not Connected";
		// display not connected message
                GlobalVariables.isConnected = false;
                ContactsViewModel cvm = new ContactsViewModel();
                cvm.UpdateConnectionState("dummy");
                directoryList.Add(new UserInfo("Not Connected", "Not Connected", 1234, "Not Connected"));
                //ContactsListBox.ItemsSource = null;
            }
            client.Close();
            //ContactsListBox.ItemsSource = directoryList;
            Loaded += new RoutedEventHandler(Contacts_Loaded);
            
        }

        
        private void AudioTimer_Tick(object sender, EventArgs e)
        {
            LoadContacts();
            Debug.WriteLine(NavigationService.Source);
            string url = NavigationService.Source.ToString();

            if (!url.Contains("RefreshCount="))
            {
                if (NavigationContext.QueryString.Count < 1)
                {
                    url += "?RefreshCount=" + ++countRefresh;
                }
                else
                {
                    url += "&RefreshCount=" + ++countRefresh;
                }
            }
            else
            {
                url = Regex.Replace(url, @"RefreshCount=+\d", "RefreshCount=" + ++countRefresh);
            }
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
        static int countRefresh;
        void Contacts_Loaded(object sender, RoutedEventArgs e)
        {
           

            Debug.WriteLine("here in contacts loaded");
            ContactsListBox.ItemsSource = directoryList;
            ContactsListBox.UpdateLayout();
            
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button source = (Button)e.OriginalSource;
            UserInfo selectedUser = (UserInfo)source.DataContext;
            GlobalVariables.selectedUser = selectedUser;
            refreshCount = 0;
            NavigationService.Navigate(new Uri("/OutgoingCallPage.xaml", UriKind.Relative));
        }

        private void STT_Click(object sender, EventArgs e)
        {
            refreshCount = 0;
            NavigationService.Navigate(new Uri("/STTPage.xaml", UriKind.Relative));
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            refreshCount = 0;
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }


        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            refreshCount = 0;
            NavigationService.Navigate(new Uri("/Help.xaml", UriKind.Relative));
        }

        private void SimulateIncomingCallButton_Click(object sender, EventArgs e)
        {
            refreshCount = 0;
            NavigationService.Navigate(new Uri("/IncomingCallPage.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            refreshCount = 0;
            LoadContacts();
            Debug.WriteLine(NavigationService.Source);
            string url = NavigationService.Source.ToString();

            if (!url.Contains("RefreshCount="))
            {
                if (NavigationContext.QueryString.Count < 1)
                {
                    url += "?RefreshCount=" + ++countRefresh;
                }
                else
                {
                    url += "&RefreshCount=" + ++countRefresh;
                }
            }
            else
            {
                url = Regex.Replace(url, @"RefreshCount=+\d", "RefreshCount=" + ++countRefresh);
            }
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
            
        }
    }
}
