﻿#pragma checksum "C:\Users\mhiga\Desktop\TalkSee\Microsoft Research\Project Hawaii SDK 2.1\Source\Samples\Translator\TranslatorSample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D263F277716A74DA27EAC3C116C24629"
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


namespace TranslatorSampleApp {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot TranslatorMode;
        
        internal Microsoft.Phone.Controls.ListPicker PickerLanguageFrom;
        
        internal Microsoft.Phone.Controls.ListPicker PickerLanguageTo;
        
        internal System.Windows.Controls.TextBox tbTextTranslatedFrom;
        
        internal System.Windows.Controls.TextBox tbTextTranslatedTo;
        
        internal System.Windows.Controls.Button btnTranslate;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
        internal Microsoft.Phone.Controls.ListPicker PickerLanguageSpeakTo;
        
        internal System.Windows.Controls.TextBox tbTextSpeak;
        
        internal System.Windows.Controls.Button btnSpeak;
        
        internal System.Windows.Controls.MediaElement soundPlayer;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/TranslatorWP7Sample;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TranslatorMode = ((Microsoft.Phone.Controls.Pivot)(this.FindName("TranslatorMode")));
            this.PickerLanguageFrom = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("PickerLanguageFrom")));
            this.PickerLanguageTo = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("PickerLanguageTo")));
            this.tbTextTranslatedFrom = ((System.Windows.Controls.TextBox)(this.FindName("tbTextTranslatedFrom")));
            this.tbTextTranslatedTo = ((System.Windows.Controls.TextBox)(this.FindName("tbTextTranslatedTo")));
            this.btnTranslate = ((System.Windows.Controls.Button)(this.FindName("btnTranslate")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
            this.PickerLanguageSpeakTo = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("PickerLanguageSpeakTo")));
            this.tbTextSpeak = ((System.Windows.Controls.TextBox)(this.FindName("tbTextSpeak")));
            this.btnSpeak = ((System.Windows.Controls.Button)(this.FindName("btnSpeak")));
            this.soundPlayer = ((System.Windows.Controls.MediaElement)(this.FindName("soundPlayer")));
        }
    }
}
