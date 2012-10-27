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
        private void Context_SaveChangesCompleted(object sender, SaveChangesCompletedArgs e)
        {
            if (e.Error != null)
            {
                Dispatcher.BeginInvoke(new Action(() =>
                {
                    MessageBox.Show(e.Error.ToString());
                }));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTextImg1_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage src = new BitmapImage();
            src.BeginInit();
            src.UriSource = testImages[(testImageIndex++) % testImages.Length];
            src.CacheOption = BitmapCacheOption.OnLoad;
            src.CreateOptions = BitmapCreateOptions.DelayCreation;
            src.DecodePixelWidth = 50;
            src.EndInit();

            AddItemCore(TextEntry.Text,src);
            TextEntry.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddText1_Click(object sender, RoutedEventArgs e)
        {
            AddItemCore(TextEntry.Text,null);
            TextEntry.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="image"></param>
        private void AddItemCore(string text, BitmapSource image)
        {
            try
            {
                ISmashTableChangeContext context = this.chat.GetTableChangeContext();
                Channels.ChatRecord record = image == null ? new Channels.ChatRecord(DateTime.Now.ToLongTimeString() + " " + text) : new Channels.ChatRecord(DateTime.Now.ToLongTimeString() + " " + text, image);
                context.Add(record);
                context.SaveChangesCompleted += new SaveChangesCompletedHandler(this.Context_SaveChangesCompleted);
                context.SaveChangesAsync(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
