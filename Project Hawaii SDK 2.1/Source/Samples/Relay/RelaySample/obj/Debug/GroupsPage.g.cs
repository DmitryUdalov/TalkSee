﻿#pragma checksum "C:\Users\mhiga\Desktop\TalkSee\Microsoft Research\Project Hawaii SDK 2.1\Source\Samples\Relay\RelaySample\GroupsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7FD0FA9AD06AFBD944C782ACF2B89038"
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
    
    
    public partial class GroupsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock MyEndpointLabel;
        
        internal System.Windows.Controls.TextBlock GroupsLabel;
        
        internal System.Windows.Controls.ListBox GroupsListBox;
        
        internal System.Windows.Controls.Button CreateGroupButton;
        
        internal System.Windows.Controls.Button DeleteGroupButton;
        
        internal System.Windows.Controls.Button JoinGroupButton;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.ListBox EndpointGroupsListBox;
        
        internal System.Windows.Controls.Button LeaveGroupButton;
        
        internal System.Windows.Controls.Button GoBackButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/RelaySampleApp;component/GroupsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MyEndpointLabel = ((System.Windows.Controls.TextBlock)(this.FindName("MyEndpointLabel")));
            this.GroupsLabel = ((System.Windows.Controls.TextBlock)(this.FindName("GroupsLabel")));
            this.GroupsListBox = ((System.Windows.Controls.ListBox)(this.FindName("GroupsListBox")));
            this.CreateGroupButton = ((System.Windows.Controls.Button)(this.FindName("CreateGroupButton")));
            this.DeleteGroupButton = ((System.Windows.Controls.Button)(this.FindName("DeleteGroupButton")));
            this.JoinGroupButton = ((System.Windows.Controls.Button)(this.FindName("JoinGroupButton")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.EndpointGroupsListBox = ((System.Windows.Controls.ListBox)(this.FindName("EndpointGroupsListBox")));
            this.LeaveGroupButton = ((System.Windows.Controls.Button)(this.FindName("LeaveGroupButton")));
            this.GoBackButton = ((System.Windows.Controls.Button)(this.FindName("GoBackButton")));
        }
    }
}

