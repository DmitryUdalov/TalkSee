﻿#pragma checksum "C:\Users\Ashley\Documents\GitHub\TalkSee\Project Hawaii SDK 2.1\Source\Samples\SpeechToText\SpeechToTextSample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8B355DC9AE8EF5F83BD695CF43131082"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17626
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace SpeechToTextSampleApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid HawaiiAppIdErrorArea;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox RecognizedStringListBox;
        
        internal System.Windows.Controls.ProgressBar RecognizingProgress;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton recordButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton stopButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton playButton;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton recognizeButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SpeechToTextSampleApp;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.HawaiiAppIdErrorArea = ((System.Windows.Controls.Grid)(this.FindName("HawaiiAppIdErrorArea")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.RecognizedStringListBox = ((System.Windows.Controls.ListBox)(this.FindName("RecognizedStringListBox")));
            this.RecognizingProgress = ((System.Windows.Controls.ProgressBar)(this.FindName("RecognizingProgress")));
            this.recordButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("recordButton")));
            this.stopButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("stopButton")));
            this.playButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("playButton")));
            this.recognizeButton = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("recognizeButton")));
            this.SettingsMenuItem = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("SettingsMenuItem")));
            this.HelpMenuItem = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("HelpMenuItem")));
        }
    }
}

