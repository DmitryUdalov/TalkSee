﻿#pragma checksum "C:\Users\mhiga\Desktop\TalkSee\Microsoft Research\Project Hawaii SDK 2.1\Source\Samples\Relay\RelaySample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D7A17B782AEC461CE08F9FD414F43E16"
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


namespace RelaySampleApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid HawaiiAppIdErrorArea;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock MyEndpointLabel;
        
        internal System.Windows.Controls.Button CreateEndPointButton;
        
        internal System.Windows.Controls.TextBlock textBlock2;
        
        internal System.Windows.Controls.ListBox EndpointGroupsListBox;
        
        internal System.Windows.Controls.Button ManageGroupsButton;
        
        internal System.Windows.Controls.Button SendMessagesButton;
        
        internal System.Windows.Controls.Button ReceiveMessagesButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RelaySampleApp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.HawaiiAppIdErrorArea = ((System.Windows.Controls.Grid)(this.FindName("HawaiiAppIdErrorArea")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MyEndpointLabel = ((System.Windows.Controls.TextBlock)(this.FindName("MyEndpointLabel")));
            this.CreateEndPointButton = ((System.Windows.Controls.Button)(this.FindName("CreateEndPointButton")));
            this.textBlock2 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock2")));
            this.EndpointGroupsListBox = ((System.Windows.Controls.ListBox)(this.FindName("EndpointGroupsListBox")));
            this.ManageGroupsButton = ((System.Windows.Controls.Button)(this.FindName("ManageGroupsButton")));
            this.SendMessagesButton = ((System.Windows.Controls.Button)(this.FindName("SendMessagesButton")));
            this.ReceiveMessagesButton = ((System.Windows.Controls.Button)(this.FindName("ReceiveMessagesButton")));
        }
    }
}
