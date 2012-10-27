// ----------------------------------------------------------
// <copyright file="MainPage.Xaml.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace SmashSampleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Animation;
    using System.Windows.Shapes;

    using Microsoft.Hawaii.Smash.Client;

    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Shell;
    using Microsoft.Phone.UserData;
    
    /// <summary>
    /// 
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// 
        /// </summary>
        private string UniqueClientKey = "SMASH Unique Client ID";

        /// <summary>
        /// 
        /// </summary>
        private string UniqueManagementIDKey = "SMASH Unique Management ID";

        /// <summary>
        /// 
        /// </summary>
        private const string ApplicationSecret = HawaiiClient.ApplicationSecret;

        /// <summary>
        /// 
        /// </summary>
        private static MainPage mainPage;

        /// <summary>
        /// 
        /// </summary>
        private static IDictionary<string, object> state;

        /// <summary>
        /// 
        /// </summary>
        private SmashSession session;

        /// <summary>
        /// 
        /// </summary>
        private SmashTable<Channels.ChatRecord> chat;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainPage()
        {
            this.InitializeComponent();

            this.VerifyHawaiiId(); 
            
            this.SendText.Click += new RoutedEventHandler(this.SendText_Click);
            this.Join.Click += new RoutedEventHandler(this.Join_Click);
            this.Create.Click += new RoutedEventHandler(this.Create_Click);

            mainPage = this;
            if (state != null)
            {
                this.chat = new SmashTable<Channels.ChatRecord>("Chat");
                this.Dispatcher.BeginInvoke(() =>
                {
                    ChatText.DataContext = this.chat;
                });
                this.session = SmashSession.JoinSessionFromState(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.Dispatcher, state, new ISmashTable[] { this.chat });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="statePreserved"></param>
        public static void ActivateSession(IDictionary<string, object> s, bool statePreserved)
        {
            if (statePreserved && mainPage != null)
            {
                state = null;
                mainPage.session.ResumeSession();
            }
            else
            {
                state = s;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public static void DeactivateSession(IDictionary<string, object> s)
        {
            if (mainPage != null && mainPage.session != null)
            {
                mainPage.session.DeactivateSession(s);
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
                throw new Exception("Credentials are not set, exiting application");
            }

            if (string.IsNullOrEmpty(HawaiiClient.ApplicationSecret))
            {
                MessageBox.Show("The ApplicationSecret is missing. Add a unique guid to HawaiiClient.cs");
                throw new Exception("Credentials are not set, exiting application");
            }
        }
    }
}