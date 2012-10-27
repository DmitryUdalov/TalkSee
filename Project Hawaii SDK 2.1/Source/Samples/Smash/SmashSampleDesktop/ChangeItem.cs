// ----------------------------------------------------------
// <copyright file="ChangeItem.cs" company="Microsoft">
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
        private void ChangeTextImg1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ISmashTableChangeContext context = null;

                foreach (Channels.ChatRecord r in ChatText.SelectedItems)
                {
                    if (!session.IsRecordOwned(r))
                    {
                        MessageBox.Show("Sample app does not change records owned by other clients.\nUnselect records not submitted by yourself and retry.\n(Smash service allows it, though)");
                        return;
                    }

                    BitmapImage src = new BitmapImage();
                    src.BeginInit();
                    src.UriSource = testImages[(testImageIndex++) % testImages.Length];
                    src.CacheOption = BitmapCacheOption.OnDemand;
                    src.CreateOptions = BitmapCreateOptions.DelayCreation;
                    src.DecodePixelWidth = 50;
                    src.EndInit();

                    if (context == null)
                    {
                        context = this.chat.GetTableChangeContext();
                    }

                    Channels.ChatRecord unfrozen = r.GetUnfrozen(context);
                    unfrozen.Text = DateTime.Now.ToLongTimeString() + " " + TextEntry.Text;
                    unfrozen.Picture = src;
                }

                if (context != null)
                {
                    ChatText.UnselectAll();
                    context.SaveChangesCompleted += new SaveChangesCompletedHandler(this.Context_SaveChangesCompleted);
                    context.SaveChangesAsync(null);
                }
                else
                {
                    MessageBox.Show("Select an item in the chat box first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            TextEntry.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeText_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ISmashTableChangeContext context = null;

                foreach (Channels.ChatRecord r in ChatText.SelectedItems)
                {
                    if (context == null)
                    {
                        context = this.chat.GetTableChangeContext();
                    }

                    Channels.ChatRecord unfrozen = r.GetUnfrozen(context);
                    unfrozen.Text = DateTime.Now.ToLongTimeString() + " " + TextEntry.Text;
                }

                if (context != null)
                {
                    ChatText.UnselectAll();
                    context.SaveChangesCompleted += new SaveChangesCompletedHandler(this.Context_SaveChangesCompleted);
                    context.SaveChangesAsync(null);
                }
                else
                {
                    MessageBox.Show("Select an item in the chat box first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            TextEntry.Text = string.Empty;
        }
    }
}
