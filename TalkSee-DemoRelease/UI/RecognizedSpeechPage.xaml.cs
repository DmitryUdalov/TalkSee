// -
// <copyright file="RecognizedSpeechPage.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace SpeechToTextSampleApp
{
    public partial class RecognizedSpeechPage : PhoneApplicationPage
    {
        public RecognizedSpeechPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) 
        {
            //this.RecognitionDetailsText.Text = App.RecognizedTextObject;
        }
    }
}