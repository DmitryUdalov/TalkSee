/* 
    Copyright (c) 2012 Microsoft Corporation.  All rights reserved.
    Use of this sample source code is subject to the terms of the Microsoft license 
    agreement under which you licensed this sample source code and is provided AS-IS.
    If you did not accept the terms of the license agreement, you are not authorized 
    to use this sample source code.  For the terms of the license, please see the 
    license agreement between you and Microsoft.
  
    To see all Code Samples for Windows Phone, visit http://go.microsoft.com/fwlink/?LinkID=219604 
  
*/
using Microsoft.Phone.Controls;
using System;
using System.Collections;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using Windows.Phone.Speech.Recognition;
using Windows.Phone.Speech.Synthesis;
using Windows.Foundation;
using System.Collections.Generic;

namespace PhoneVoIPApp.UI
{
    public partial class CallStatusPage : BasePage
    {
        SpeechSynthesizer synthesizer;
        SpeechRecognizer recognizer;
        IAsyncOperation<SpeechRecognitionResult> recoOperation;

        //bool _isNew = true;
        bool recoEnabled = false;
        public CallStatusPage()
            : base(new CallStatusViewModel())
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs nee)
        {
            
            base.OnNavigatedTo(nee);
            // Register for the Obscured/Unobscured events
            PhoneApplicationFrame rootFrame = ((App)Application.Current).RootFrame;
            rootFrame.Obscured += ((CallStatusViewModel)this.ViewModel).RootFrame_Obscured;
            rootFrame.Unobscured += ((CallStatusViewModel)this.ViewModel).RootFrame_Unobscured;

            // Re-bind MediaElements explictly, so video will play after app has been resumed
            bigHead.SetBinding(MediaElement.SourceProperty, new System.Windows.Data.Binding("BigHeadPreviewUri"));
            littleHead.SetBinding(MediaElement.SourceProperty, new System.Windows.Data.Binding("LittleHeadPreviewUri"));
           /* try
            {
                // Create the speech recognizer and speech synthesizer objects. 
                if (this.synthesizer == null)
                {
                    this.synthesizer = new SpeechSynthesizer();
                }
                if (this.recognizer == null)
                {
                    this.recognizer = new SpeechRecognizer();
                }
                // Set up a list of colors to recognize.
                this.recognizer.Grammars.AddGrammarFromList("Colors", new List<string>() { "red", "cyan", "blue", "yellow", "orange", "fire color", "purple", "black", "jet black", "green", "white", "dark gray", "brown", "magenta", "gray" });
            }
            catch (Exception err)
            {
                this.SetRecognizedTextListBox(err.ToString());
                //txtResult.Text = err.ToString();
            }
            startSTT();*/
            
        }

        private async void startSTT()
        {
            // Change the button text. 
            if (this.recoEnabled)
            {
                this.recoEnabled = false;
                //this.SetRecognizedTextListBox(String.Empty);
                this.recoOperation.Cancel();
                return;
            }
            else
            {
                this.recoEnabled = true;
            }

            while (this.recoEnabled)
            {
                Debug.WriteLine("here\n");
                try
                {
                    // Perform speech recognition.  
                    this.recoOperation = recognizer.RecognizeAsync();
                    var recoResult = await this.recoOperation;

                    // Check the confidence level of the speech recognition attempt.
                    if ((int)recoResult.TextConfidence < (int)SpeechRecognitionConfidence.Low)
                    {
                        // If the confidence level of the speech recognition attempt is low, 
                        // ask the user to try again.
                        this.SetRecognizedTextListBox("Not sure what you said, please try again.");
                        Debug.WriteLine("Not sure what you said");
                        //txtResult.Text = "Not sure what you said, please try again.";
                        await synthesizer.SpeakTextAsync("Not sure what you said, please try again");
                    }
                    else
                    {
                        // Output that the color of the rectangle is changing by updating
                        // the TextBox control and by using text-to-speech (TTS). 
                        Debug.WriteLine(recoResult.Text);
                        //this.SetRecognizedTextListBox(recoResult.Text);
                        //txtResult.Text = "Changing color to: " + recoResult.Text;
                        await synthesizer.SpeakTextAsync("Changing color to " + recoResult.Text);

                        
                    }
                }
                catch (System.Threading.Tasks.TaskCanceledException)
                {
                    // Ignore the cancellation exception of the recoOperation.
                }
                catch (Exception err)
                {
                    // Handle the speech privacy policy error.
                    const int privacyPolicyHResult = unchecked((int)0x80045509);

                    if (err.HResult == privacyPolicyHResult)
                    {
                        MessageBox.Show("You must accept the speech privacy policy to continue.");
                        this.recoEnabled = false;
                    }
                    else
                    {
                        //this.SetRecognizedTextListBox("Error: " + err.Message);
                        Debug.WriteLine("Error: " + err.Message);
                        //txtResult.Text = "Error: " + err.Message;
                    }
                }
            }

        }

        /// <summary>
        /// Delegate method to populate recognition results in the list box.
        /// </summary>
        /// <param name="recognitionResultStrings">
        /// List of recognition results.
        /// </param>
        private void SetRecognizedTextListBox(string recognitionResultStrings)//List<string> recognitionResultStrings)
        {
            if (recognitionResultStrings != null)
            {
                //if (recognitionResultStrings.Count == 0)
                //{
              
                    //this.RecognizedStringListBox.Items.Add("Empty recognized text is received.");
                    this.RecognizedStringListBox.Items.Add(recognitionResultStrings);
                //}
                //else
                //{
                  //  recognitionResultStrings.ForEach((item) => this.RecognizedStringListBox.Items.Add(item));
                    ///this.RecognizedStringListBox.Items.Add(recognitionResultStrings);
                //}
            }
            else
            {
                this.RecognizedStringListBox.Items.Add("Sorry, unable to recognize speech");
            }
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs nee)
        {
            base.OnNavigatedFrom(nee);
            // Unregister for the Obscured/Unobscured events
            PhoneApplicationFrame rootFrame = ((App)Application.Current).RootFrame;
            rootFrame.Obscured -= ((CallStatusViewModel)this.ViewModel).RootFrame_Obscured;
            rootFrame.Unobscured -= ((CallStatusViewModel)this.ViewModel).RootFrame_Unobscured;
        }

        private void HangUpButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //startSTT();
            ((CallStatusViewModel)this.ViewModel).HangUp();
        }

        private void HoldButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //startSTT();
            ((CallStatusViewModel)this.ViewModel).ToggleHold();
        }

        private void CameraToggleButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ((CallStatusViewModel)this.ViewModel).ToggleCamera();
        }

        

        private void littleHead_MediaOpened_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Debug.WriteLine("[CallStatusPage] LittleHead Opened: " + ((MediaElement)sender).Source.AbsoluteUri);            
        }

        private void bigHead_MediaOpened_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Debug.WriteLine("[CallStatusPage] BigHead Opened: " + ((MediaElement)sender).Source.AbsoluteUri);
        }

        private void bigHead_MediaFailed_1(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {
            Debug.WriteLine("[CallStatusPage] BigHead Failed: " + e.ErrorException.Message);
        }

        private void littleHead_MediaFailed_1(object sender, System.Windows.ExceptionRoutedEventArgs e)
        {
            Debug.WriteLine("[CallStatusPage] LittleHead Failed: " + e.ErrorException.Message);
        }

        

        /// <summary>
        /// Navigates to the Recognition details page when a recognition string 
        /// is selected from the list box of matches.
        /// </summary>
        /// <param name="sender">
        /// Sender object.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void RecognizedStringListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems == null)
            {
                return;
            }
            else if (e.AddedItems.Count == 0)
            {
                return;
            }
            else
            {
                IList selectedItems = e.AddedItems;
                App.RecognizedTextObject = selectedItems.OfType<string>().FirstOrDefault();

                NavigationService.Navigate(new Uri("/RecognizedSpeechPage.xaml", UriKind.Relative));

                RecognizedStringListBox.SelectedItem = null;
            }
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }


        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Help.xaml", UriKind.Relative));
        }
    }
}
