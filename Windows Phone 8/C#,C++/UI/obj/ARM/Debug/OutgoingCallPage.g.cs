﻿#pragma checksum "C:\Users\Ashley\Documents\GitHub\TalkSee\Windows Phone 8\C#,C++\UI\OutgoingCallPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2BE3E99FCBAD84FDB37105FAEEC0D1F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Shell;
using PhoneVoIPApp.UI;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PhoneVoIPApp.UI {
    
    
    public partial class OutgoingCallPage : PhoneVoIPApp.UI.BasePage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitleText;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel MainStackPanel;
        
        internal System.Windows.Controls.TextBox RecipientNameTextBox;
        
        internal System.Windows.Controls.TextBox RecipientNumberTextBox;
        
        internal System.Windows.Controls.StackPanel BottomStackPanel;
        
        internal System.Windows.Controls.TextBlock DisabledReasonText;
        
        internal System.Windows.Controls.Button DialButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem SettingsMenuItem;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem HelpMenuItem;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneVoIPApp.UI;component/OutgoingCallPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitleText = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitleText")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MainStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("MainStackPanel")));
            this.RecipientNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("RecipientNameTextBox")));
            this.RecipientNumberTextBox = ((System.Windows.Controls.TextBox)(this.FindName("RecipientNumberTextBox")));
            this.BottomStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("BottomStackPanel")));
            this.DisabledReasonText = ((System.Windows.Controls.TextBlock)(this.FindName("DisabledReasonText")));
            this.DialButton = ((System.Windows.Controls.Button)(this.FindName("DialButton")));
            this.SettingsMenuItem = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("SettingsMenuItem")));
            this.HelpMenuItem = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("HelpMenuItem")));
        }
    }
}

