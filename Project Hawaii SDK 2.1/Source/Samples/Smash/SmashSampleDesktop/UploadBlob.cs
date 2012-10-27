// ----------------------------------------------------------
// <copyright file="AddItem.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace SmashSampleAppDesktop
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
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
    using System.Windows.Resources;
    using System.Windows.Shapes;

    using Microsoft.Hawaii.Smash.Client;
    using Microsoft.Hawaii.Smash.Client.Common;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        void UploadBlob_Click(object sender, RoutedEventArgs e)
        {
            SessionManager sessionManager = new SessionManager();
            sessionManager.CreateBlobCompleted += new CreateBlobCompletedHandler(sessionManager_CreateBlobCompleted);
            sessionManager.CreateBlobAsync(this.session, ".jpg", null);
        }

        void sessionManager_CreateBlobCompleted(object sender, CreateBlobCompletedArgs e)
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
                StreamResourceInfo resource = Application.GetResourceStream(new Uri("pack://application:,,,/19-baby-tiger.jpg"));
                
                e.BlobUploader.UploadCompleted += new UploadCompletedHandler(this.BlobUploader_UploadCompleted);
                e.BlobUploader.UploadAsync(resource.Stream, null);
            }
        }

        void BlobUploader_UploadCompleted(object sender, UploadCompletedArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(e.Error.ToString());
                    }
                    else
                    {
                        TextEntry.Text = e.BlobAddress;
                    }
                }));
        }
    }
}
