﻿#pragma checksum "C:\Users\mhiga\Desktop\TalkSee\Microsoft Research\Project Hawaii SDK 2.1\Source\Samples\KeyValue\KeyValueSample\KeyvalueDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FB58802E3614F15AB771276A8EFFF7E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace KeyValueSampleApp {
    
    
    public partial class KeyvalueDetails : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button btnSave;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.TextBox txbKey;
        
        internal System.Windows.Controls.TextBox txbValue;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/KeyValueSampleApp;component/KeyvalueDetails.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.btnSave = ((System.Windows.Controls.Button)(this.FindName("btnSave")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.txbKey = ((System.Windows.Controls.TextBox)(this.FindName("txbKey")));
            this.txbValue = ((System.Windows.Controls.TextBox)(this.FindName("txbValue")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
        }
    }
}

