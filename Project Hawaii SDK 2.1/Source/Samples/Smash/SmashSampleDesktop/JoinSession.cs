// ----------------------------------------------------------
// <copyright file="JoinSession.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace SmashSampleAppDesktop
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
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

    using Microsoft.Hawaii.Smash.Client;
    using Microsoft.Hawaii.Smash.Client.Common;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
        /// <param name="meetingToken"></param>
        /// <param name="token"></param>
        private void ExecuteJoinSession(Guid meetingToken, string token)
        {
            if (this.session != null)
            {
                this.session.Shutdown();
                this.session = null;
            }

            string machineName = System.Environment.MachineName;

            if (this.clientInstance > 0)
            {
                machineName += "_" + this.clientInstance.ToString();
            }

            SessionManager sessionManager = new SessionManager();
            sessionManager.JoinSessionCompleted += new JoinSessionCompletedHandler(this.SessionManager_JoinSessionCompleted);
            sessionManager.JoinSessionAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.Dispatcher, meetingToken, this.userName, this.userEmail, machineName, new ISmashTable[] { this.chat }, token);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JoinSession_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Guid meetingToken = Guid.Empty;

                if (Guid.TryParse(TextEntry.Text, out meetingToken))
                {
                    this.ExecuteJoinSession(meetingToken, null);
                }
                else if (TextEntry.Text.Length == 6)
                {
                    this.ExecuteJoinSession(this.GetMeetingToken(TextEntry.Text), TextEntry.Text);
                }
                else
                {
                    MessageBox.Show("Please specify session Token");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

            Dispatcher.BeginInvoke(new Action(() =>
            {
                if (e.Error != null)
                {
                    MessageBox.Show(e.Error.ToString());
                }
                else if (this.session != null && !this.session.SessionID.Equals(Guid.Empty))
                {
                    SmashAppDesktop.Title = string.Format("SmashSampleAppDesktop: User {0} joined to {1}", userName, this.session.SessionID.ToString());
                    if (e.UserState != null && e.UserState is string)
                    {
                        TextEntry.Text = "TOKEN=" + (e.UserState as string);
                    }
                    else
                    {
                        TextEntry.Text = this.session.MeetingToken.ToString();
                    }
                }
            }));
        }
    }
}
