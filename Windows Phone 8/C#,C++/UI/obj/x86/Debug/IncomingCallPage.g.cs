﻿#pragma checksum "C:\Users\Ashley\Documents\GitHub\TalkSee\Windows Phone 8\C#,C++\UI\IncomingCallPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DFB90B38C3FAB4D1F2E9CD07EDBE47BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class IncomingCallPage : PhoneVoIPApp.UI.BasePage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitleText;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel MainStackPanel;
        
        internal System.Windows.Controls.TextBox CallerNameTextBox;
        
        internal System.Windows.Controls.TextBox CallerNumberTextBox;
        
        internal System.Windows.Controls.StackPanel BottomStackPanel;
        
        internal System.Windows.Controls.TextBlock ResultText;
        
        internal System.Windows.Controls.Button SimulateButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/PhoneVoIPApp.UI;component/IncomingCallPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitleText = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitleText")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MainStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("MainStackPanel")));
            this.CallerNameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("CallerNameTextBox")));
            this.CallerNumberTextBox = ((System.Windows.Controls.TextBox)(this.FindName("CallerNumberTextBox")));
            this.BottomStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("BottomStackPanel")));
            this.ResultText = ((System.Windows.Controls.TextBlock)(this.FindName("ResultText")));
            this.SimulateButton = ((System.Windows.Controls.Button)(this.FindName("SimulateButton")));
        }
    }
}
