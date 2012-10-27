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
        private void EnumSessions_Core()
        {
            try
            {
                SessionManager sessionManager = new SessionManager();
                sessionManager.EnumSessionsCompleted += new EnumSessionsCompletedHandler(this.SessionManager_EnumSessionsCompleted);
                sessionManager.EnumSessionsAsync(HawaiiClient.AdmClientId, HawaiiClient.AdmClientSecret, new Guid(ManagementID), null);
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
        private void EnumSessions_Click(object sender, RoutedEventArgs e)
        {
            this.EnumSessions_Core();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionManager_EnumSessionsCompleted(object sender, EnumSessionCompletedArgs e)
        {
            if (e.Error != null)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show(e.Error.ToString());
                }));
            }
            else
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    ObservableCollection<SessionInfo> sessionInfos = new ObservableCollection<SessionInfo>(e.SessionInfos);
                    SessionList.DataContext = sessionInfos;
                }));
            }
        }
    }
}
