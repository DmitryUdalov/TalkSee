// ----------------------------------------------------------
// <copyright file="MainWindow.Xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace SmashSampleAppDesktop
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    using Microsoft.Hawaii;

    using Microsoft.Hawaii.Smash.Client;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// 
        /// </summary>
        private const string ApplicationSecret = HawaiiClient.ApplicationSecret;

        /// <summary>
        /// 
        /// </summary>
        private string ManagementID;

        /// <summary>
        /// 
        /// </summary>
        private SmashSession session;

        /// <summary>
        /// 
        /// </summary>
        private SmashTable<Channels.ChatRecord> chat;

        /// <summary>
        /// 
        /// </summary>
        private string userName = "SampleUser";

        /// <summary>
        /// 
        /// </summary>
        private string userEmail = "sample@sample.com";

        /// <summary>
        /// 
        /// </summary>
        private int clientInstance = 0;

        /// <summary>
        /// 
        /// </summary>
        private Mutex instanceMutex = null;

        /// <summary>
        /// 
        /// </summary>
        private Uri[] testImages = new Uri[]{
                                            new Uri("pack://application:,,,/Koala.jpg"),
                                            new Uri("pack://application:,,,/Penguins.jpg"),
                                            new Uri("pack://application:,,,/puppies.jpg")
                                            };

        /// <summary>
        /// 
        /// </summary>
        private int testImageIndex = 0;

        /// <summary>
        /// 
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            this.VerifyHawaiiId();

            // A unique secret for the management ID. This sample app derives this from the application secret and a hash of the current user name.
            byte [] h = BitConverter.GetBytes(Environment.UserName.GetHashCode());
            Guid g = new Guid(ApplicationSecret);
            byte[] b = g.ToByteArray();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] ^= h[i % h.Length];
            }
            this.ManagementID = (new Guid(b)).ToString();

            this.chat = new SmashTable<Channels.ChatRecord>("Chat");

            while (this.instanceMutex == null)
            {
                string mutexName = @"Global\MUTEX" + ApplicationSecret + "_" + this.clientInstance.ToString();
                bool createdNew;
                this.instanceMutex = new Mutex(true, mutexName, out createdNew);
                if (!createdNew)
                {
                    using (Mutex dispose = this.instanceMutex)
                    {
                        this.instanceMutex = null;
                    }

                    this.clientInstance++;
                }
            }

            ChatText.DataContext = this.chat;

            AddText1.Click += new RoutedEventHandler(this.AddText1_Click);
            AddTextImg1.Click += new RoutedEventHandler(this.AddTextImg1_Click);
            ChangeText.Click += new RoutedEventHandler(this.ChangeText_Click);
            ChangeTextImg1.Click += new RoutedEventHandler(this.ChangeTextImg1_Click);
            DeleteItem.Click += new RoutedEventHandler(this.DeleteItem_Click);
            UploadBlob.Click += new RoutedEventHandler(this.UploadBlob_Click);

            JoinSession.Click += new RoutedEventHandler(this.JoinSession_Click);
            CreateSession.Click += new RoutedEventHandler(this.CreateSession_Click);
            EnumSessions.Click += new RoutedEventHandler(this.EnumSessions_Click);
            WipeSession.Click += new RoutedEventHandler(this.WipeSession_Click);

            this.Closed += new EventHandler(this.MainWindow_Closed);

            string meetingToken = string.Empty;

            string[] args = Environment.GetCommandLineArgs();
            foreach (string a in args)
            {
                if (a.StartsWith("m="))
                {
                    meetingToken = a.Substring(2);
                }
            }

            if (!string.IsNullOrEmpty(meetingToken))
            {
                this.ExecuteJoinSession(this.GetMeetingToken(meetingToken), meetingToken);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closed(object sender, EventArgs e)
        {
            if (this.instanceMutex != null)
            {
                this.instanceMutex.Close();
            }

            if (this.session != null)
            {
                this.session.Shutdown();
            }
        }

        /// <summary>
        /// Verify that the Hawaii application Id is set correctly.
        /// </summary>
        private void VerifyHawaiiId()
        {
            if (string.IsNullOrEmpty(HawaiiClient.AdmClientId) ||
                string.IsNullOrEmpty(HawaiiClient.AdmClientSecret))
            {
                MessageBox.Show("The Adm client Id or client secret is missing. Please consult the \"Project Hawaii Installation Guide\" on how to obtain credentials");
                Environment.Exit(1);
            }

            if (string.IsNullOrEmpty(HawaiiClient.ApplicationSecret))
            {
                MessageBox.Show("The ApplicationSecret is missing. Add a unique guid to HawaiiClient.cs");
                Environment.Exit(1);
            }
        }
    }
}
