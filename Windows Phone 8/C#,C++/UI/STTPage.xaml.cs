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
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using Windows.Foundation;
using Windows.Phone.Speech.Recognition;
using Windows.Phone.Speech.Synthesis;

namespace sdkSpeechColorChangeWP8CS
{
    public partial class MainPage : PhoneApplicationPage
    {
        Dictionary<string, SolidColorBrush> _colorBrushes;

        SpeechSynthesizer synthesizer;
        SpeechRecognizer recognizer;
        IAsyncOperation<SpeechRecognitionResult> recoOperation;

        bool _isNew = true;
        bool recoEnabled = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            // On first run, set up the dictionary of SolidColorBrush objects. 
            if (_isNew)
            {
                _colorBrushes = new Dictionary<string, SolidColorBrush>();
                _colorBrushes.Add("red", new SolidColorBrush(Colors.Red));
                _colorBrushes.Add("cyan", new SolidColorBrush(Colors.Cyan));
                _colorBrushes.Add("blue", new SolidColorBrush(Colors.Blue));
                _colorBrushes.Add("yellow", new SolidColorBrush(Colors.Yellow));
                _colorBrushes.Add("orange", new SolidColorBrush(Colors.Orange));
                _colorBrushes.Add("fire color", new SolidColorBrush(Colors.Magenta));
                _colorBrushes.Add("purple", new SolidColorBrush(Colors.Purple));
                _colorBrushes.Add("black", new SolidColorBrush(Colors.Black));
                _colorBrushes.Add("jet black", new SolidColorBrush(Colors.Black));
                _colorBrushes.Add("green", new SolidColorBrush(Colors.Green));
                _colorBrushes.Add("white", new SolidColorBrush(Colors.White));
                _colorBrushes.Add("dark gray", new SolidColorBrush(Colors.DarkGray));
                _colorBrushes.Add("brown", new SolidColorBrush(Colors.Brown));
                _colorBrushes.Add("magenta", new SolidColorBrush(Colors.Magenta));
                _colorBrushes.Add("gray", new SolidColorBrush(Colors.Gray));
                _isNew = false;
            }

            try
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
                txtResult.Text = err.ToString();
            }

            base.OnNavigatedTo(e);
        }

        private async void btnContinuousRecognition_Click(object sender, RoutedEventArgs e)
        {
            // Change the button text. 
            if (this.recoEnabled)
            {
                this.recoEnabled = false;
                this.btnContinuousRecognition.Content = "Start speech recognition";
                txtResult.Text = String.Empty;
                this.recoOperation.Cancel();
                return;
            }
            else
            {
                this.recoEnabled = true;
                this.btnContinuousRecognition.Content = "Cancel speech recognition";
            }

            while (this.recoEnabled)
            {
                try
                {
                    // Perform speech recognition.  
                    this.recoOperation = recognizer.RecognizeAsync();
                    var recoResult = await this.recoOperation;

                    // Check the confidence level of the speech recognition attempt.
                    if ((int)recoResult.TextConfidence < (int)SpeechRecognitionConfidence.Medium)
                    {
                        // If the confidence level of the speech recognition attempt is low, 
                        // ask the user to try again.
                        txtResult.Text = "Not sure what you said, please try again.";
                        await synthesizer.SpeakTextAsync("Not sure what you said, please try again");
                    }
                    else
                    {
                        // Output that the color of the rectangle is changing by updating
                        // the TextBox control and by using text-to-speech (TTS). 
                        txtResult.Text = "Changing color to: " + recoResult.Text;
                        await synthesizer.SpeakTextAsync("Changing color to " + recoResult.Text);

                        // Set the fill color of the rectangle to the recognized color. 
                        rectangleResult.Fill = getBrush(recoResult.Text.ToLower());
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
                        this.btnContinuousRecognition.Content = "Start speech recognition";
                    }
                    else
                    {
                        txtResult.Text = "Error: " + err.Message;
                    }
                }
            }

        }

        /// <summary>
        /// Returns a SolidColorBrush that matches the recognized color string.
        /// </summary>
        /// <param name="reco">The recognized color string.</param>
        /// <returns>The matching colored SolidColorBrush.</returns>
        private SolidColorBrush getBrush(string recognizedColor)
        {
            if (_colorBrushes.ContainsKey(recognizedColor))
                return _colorBrushes[recognizedColor];

            return new SolidColorBrush(Colors.White);
        }
    }
}
