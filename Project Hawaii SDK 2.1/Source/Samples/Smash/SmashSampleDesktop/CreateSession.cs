// ----------------------------------------------------------
// <copyright file="CreateSession.cs" company="Microsoft">
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionManager_CreateSessionCompleted(object sender, CreateSessionCompletedArgs e)
        {
            if (e.Error != null)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show(e.Error.ToString());
                }));
            }
            else if (!e.Cancelled)
            {
                this.ExecuteJoinSession(e.MeetingToken, (string)e.UserState);   // Auto-join session after creation
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateSession_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string token;
                SessionManager sessionManager = new SessionManager();
                sessionManager.CreateSessionCompleted += new CreateSessionCompletedHandler(this.SessionManager_CreateSessionCompleted);
                sessionManager.CreateSessionAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, this.GetMeetingToken(out token), TextEntry.Text, this.userName, this.userEmail, new string[] { "*" }, TimeSpan.FromMinutes(60), new Guid(ManagementID), token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
