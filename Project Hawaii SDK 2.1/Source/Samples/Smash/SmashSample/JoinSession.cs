// ----------------------------------------------------------
// <copyright file="JoinSession.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace SmashSampleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO.IsolatedStorage;
    using System.Linq;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.Text;
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
    using Microsoft.Phone.UserData;

    /// <summary>
    /// 
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private Guid GetMeetingToken(string token)
        {
            Guid tmp = new Guid(ApplicationSecret);
            byte[] b0 = tmp.ToByteArray();
            byte[] b1 = UnicodeEncoding.Unicode.GetBytes(token.ToUpperInvariant());

            for (int i = 0; i < b0.Length && i < b1.Length; i++)
            {
                b0[i] ^= b1[i];
            }

            return new Guid(b0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private Guid GetMeetingToken(out string token)
        {
            Random r = new Random();
            token = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                int j = r.Next(0, 36);

                if (j < 10)
                {
                    token += new string((char)(j + '0'), 1);
                }
                else
                {
                    token += new string((char)(j - 10 + 'A'), 1);
                }
            }

            return this.GetMeetingToken(token);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>a unique, randomly initialized, stable client ID</returns>
        private string GetUniqueStableID(string key)
        {
            string clientID;

            if (!IsolatedStorageSettings.ApplicationSettings.TryGetValue(key, out clientID))
            {
                clientID = Guid.NewGuid().ToString();
                IsolatedStorageSettings.ApplicationSettings.Add(key, clientID);
            }

            return clientID;
        }

        /// <summary>
        /// Smash requires client devices to have unique names to join a session
        /// This method initializes a random identifier and stores it in the application's isolated storage for future invocations
        /// Due to the random nature of the identifier, users cannot be tracked or identified
        /// </summary>
        /// <returns></returns>
        private string GetUniqueClientID()
        {
            return GetUniqueStableID(UniqueClientKey);
        }

        /// <summary>
        /// Smash recommends that each client application instance uses a unique, private ManagementID
        /// This method initializes a random identifier and stores it in the application's isolated storage for future invocations
        /// Due to the random nature of the identifier, ManagementIDs cannot be guessed by other clients
        /// </summary>
        /// <returns></returns>
        private string GetUniqueManagementID()
        {
            return GetUniqueStableID(UniqueManagementIDKey);
        }

        /// <summary>
        /// 
        /// </summary>
        private void JoinMeeting()
        {
            if (this.session != null)
            {
                this.session.Shutdown();
                this.session = null;
            }

            this.Join.IsEnabled = false;
            this.Create.IsEnabled = false;

            string token;
            string user = "Sample User";
            string email = "sample@sample.com";

            token = TextEntry.Text;

            if (token.Length != 6)
            {
                this.Dispatcher.BeginInvoke(() =>
                {
                    MessageBox.Show("Please type a 6 character alphanumeric session code first.");
                    this.Join.IsEnabled = true;
                    this.Create.IsEnabled = true;
                });
            }
            else
            {
                this.chat = new SmashTable<Channels.ChatRecord>("Chat");
                Dispatcher.BeginInvoke(() =>
                {
                    ChatText.DataContext = this.chat;
                });
                SessionManager sessionManager = new SessionManager();
                sessionManager.JoinSessionCompleted += new JoinSessionCompletedHandler(this.SessionManager_JoinSessionCompleted);
                sessionManager.JoinSessionAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.Dispatcher, this.GetMeetingToken(token), user, email, GetUniqueClientID(), new ISmashTable[] { this.chat }, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionManager_JoinSessionCompleted(object sender, JoinSessionCompletedArgs e)
        {
            this.session = e.Session;
            this.Dispatcher.BeginInvoke(() =>
            {
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.ToString());
                }
                this.Join.IsEnabled = true;
                this.Create.IsEnabled = true;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Join_Click(object sender, RoutedEventArgs e)
        {
            this.JoinMeeting();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CreateMeeting()
        {
            this.Join.IsEnabled = false;
            this.Create.IsEnabled = false;

            string token;
            string user = "Sample User";
            string email = "sample@sample.com";

            SessionManager sessionManager = new SessionManager();
            sessionManager.CreateSessionCompleted += new CreateSessionCompletedHandler(this.SessionManager_CreateSessionCompleted);
            sessionManager.CreateSessionAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.GetMeetingToken(out token), TextEntry.Text, user, email, new string[] { "*" }, TimeSpan.FromMinutes(60), new Guid(this.GetUniqueManagementID()), token);

            TextEntry.Text = token;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionManager_CreateSessionCompleted(object sender, CreateSessionCompletedArgs e)
        {
            if (e.Error != null)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show(e.Error.ToString());
                    this.Join.IsEnabled = true;
                    this.Create.IsEnabled = true;
                }));
            }
            else if (!e.Cancelled)
            {
                this.Dispatcher.BeginInvoke(() =>
                {
                    this.JoinMeeting();
                });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            this.CreateMeeting();
        }
    }
}