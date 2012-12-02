
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

        SpeechSynthesizer synthesizer;
        SpeechRecognizer recognizer;
        IAsyncOperation<SpeechRecognitionResult> recoOperation;

        bool recoEnabled = false;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
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

            }
            catch (Exception err)
            {
                this.RecognizedStringListBox.Items.Add("error creating speech recognizer");
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
                this.Dispatcher.BeginInvoke(delegate { status.Text = ""; });
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
                recognizer.AudioCaptureStateChanged += recognizer_AudioCaptureStateChanged;

                try
                {
                    // Perform speech recognition.  
                    this.recoOperation = recognizer.RecognizeAsync();
                    var recoResult = await this.recoOperation;

                    //Check the confidence level of the speech recognition attempt.
                    if ((int)recoResult.TextConfidence < (int)SpeechRecognitionConfidence.Low)
                    {
                        // If the confidence level of the speech recognition attempt list low, 
                        // ask the user to try again.
                        this.RecognizedStringListBox.Items.Add("...?");
                        RecognizedStringListBox.SelectedIndex = RecognizedStringListBox.Items.Count - 1;
                        RecognizedStringListBox.SelectedIndex = -1;
                        //await synthesizer.SpeakTextAsync("Not sure what you said, please try again");
                    } 
                    else
                    {
                        this.RecognizedStringListBox.Items.Add(recoResult.Text);
                        RecognizedStringListBox.SelectedIndex = RecognizedStringListBox.Items.Count - 1;
                        RecognizedStringListBox.SelectedIndex = -1;
                       // await synthesizer.SpeakTextAsync(recoResult.Text);

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
                        //this.RecognizedStringListBox.Items.Add("");
                    }
                }
            }

        }

        void recognizer_AudioCaptureStateChanged(SpeechRecognizer sender, SpeechRecognizerAudioCaptureStateChangedEventArgs args)
        {
            if (args.State == SpeechRecognizerAudioCaptureState.Capturing)
            {
                this.Dispatcher.BeginInvoke(delegate { status.Text = "Listening"; });
            }
            else if (args.State == SpeechRecognizerAudioCaptureState.Inactive)
            {
                this.Dispatcher.BeginInvoke(delegate { status.Text = "Thinking"; });
            }
        }


        private void Send_Click(object sender, RoutedEventArgs e)
        {
            this.RecognizedStringListBox.Items.Add(InputTB.Text);
            InputTB.Focus();
            RecognizedStringListBox.SelectedIndex = RecognizedStringListBox.Items.Count - 1;
            RecognizedStringListBox.SelectedIndex = -1;

        }

        //The foreground color of the text in InputTB is set to Magenta when SearchTB
        //gets focus.
        private void InputTB_GotFocus(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(delegate { status.Text = ""; });
            InputTB.Text = "";
            SolidColorBrush Brush1 = new SolidColorBrush();
            Brush1.Color = Colors.Black;
            InputTB.Foreground = Brush1;

            if (this.recoEnabled == true)
            {
                this.recoEnabled = false;
                this.btnContinuousRecognition.Content = "Start speech recognition";
            }
        }

        //The foreground color of the text in InputTB is set to Blue when SearchTB
        //loses focus. Also, if InputTB loses focus and no text is entered, the
        //text "Search" is displayed.
        private void InputTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (InputTB.Text == String.Empty)
            {
                InputTB.Text = "Touch to type input";
                SolidColorBrush Brush2 = new SolidColorBrush();
                Brush2.Color = Colors.Gray;
                InputTB.Foreground = Brush2;
            }

        }
        
     
    }
}
