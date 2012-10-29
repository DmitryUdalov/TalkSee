// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Microsoft.Hawaii;
using Microsoft.Hawaii.Speech.Client;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System.Windows.Data;

namespace SpeechToTextSampleApp
{
    /// <summary>
    /// Application Main Page class.
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// Field to store the available grammars.
        /// </summary>
        private List<string> availableGrammars;

        public MainPage()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainPage_Loaded);
            this.VerifyHawaiiIdentity();

            this.AudioStream = new MemoryStream();
            this.MicroPhone = Microphone.Default;
            this.IsSoundPlaying = false;

            // Timer to simulate the XNA Framework game loop (Microphone is 
            // from the XNA Framework). We also use this timer to monitor the 
            // state of audio playback so we can update the UI appropriately.
            DispatcherTimer dispatchTimer = new DispatcherTimer();
            dispatchTimer.Interval = TimeSpan.FromMilliseconds(33);
            dispatchTimer.Tick += new EventHandler(this.DispatcherTimer_Tick);
            dispatchTimer.Start();

            // Event handler for getting audio data when the buffer is full
            this.MicroPhone.BufferReady += new EventHandler<EventArgs>(this.Microphone_BufferReady);

            SpeechService.GetGrammarsAsync(
                HawaiiClient.HawaiiApplicationId,
                (result) =>
                {
                    this.Dispatcher.BeginInvoke(() => this.OnSpeechGrammarsReceived(result));
                });

            //this.RetrievingGrammarsLabel.Visibility = Visibility.Visible;
            this.RecognizingProgress.Visibility = Visibility.Visible;

        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //List<UserInfo> directoryList = new List<UserInfo>();
            //string name = "Test";
            //int port = 3459;
            //int id = 1109;
            //string status = "Available";
            //directoryList.Add(new UserInfo(name, port, id, status));
            //Create the source string
            //string s = "Test";

            //Create the binding description
            //Binding b = new Binding("");
            //b.Mode = BindingMode.OneTime;
            //b.Source = s;

            //Attach the binding to the target  
            //TitlePanel.SetBinding(TextBlock.TextProperty, b);
            
        }

        /// <summary>
        /// Delegate definition for SetRecognizedText.
        /// </summary>
        /// <param name="recognizedTexts">
        /// List of recognized results.
        /// </param>
        private delegate void SetRecognizedTextDelegate(List<string> recognizedTexts);

        /// <summary>
        /// Delegate definition for SetGrammars.
        /// </summary>
        private delegate void SetGrammarsDelegate();

        /// <summary>
        /// Gets or sets the object representing the physical microphone on the device.
        /// </summary>
        private Microphone MicroPhone { get; set; }

        /// <summary>
        /// Gets or sets dynamic buffer to retrieve audio data from the microphone.
        /// </summary>
        private byte[] AudioBuffer { get; set; }

        /// <summary>
        /// Gets or sets the audio data for later playback.
        /// </summary>
        private MemoryStream AudioStream { get; set; }

        /// <summary>
        /// Gets or sets the SoundEffect class we need to instantiate the SoundInstance.
        /// </summary>
        private SoundEffect SoundEffect { get; set; }

        /// <summary>
        /// Gets or sets the sound instance to play back audio.
        /// </summary>
        private SoundEffectInstance SoundInstance { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sound is playing.
        /// </summary>
        private bool IsSoundPlaying { get; set; }

        /// <summary>
        /// Verify that the Hawaii identity is set correctly.
        /// </summary>
        private void VerifyHawaiiIdentity()
        {
            if (string.IsNullOrEmpty(HawaiiClient.HawaiiApplicationId))
            {
                MessageBox.Show("Service credentials are not set. Please consult the \"Project Hawaii Installation Guide\" on how to obtain credentials");
                throw new Exception("Credentials are not set, exiting application");
            }
        }

        /// <summary>
        /// Updates the XNA FrameworkDispatcher and checks to see if a sound is playing.
        /// If sound has stopped playing, it updates the UI.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                FrameworkDispatcher.Update();
            }
            catch
            {
            }

            if (true == this.IsSoundPlaying)
            {
                if (this.SoundInstance.State != SoundState.Playing)
                {
                    // Audio has finished playing
                    this.IsSoundPlaying = false;

                    // Update the UI to reflect that the 
                    // sound has stopped playing
                    this.SetButtonStates(true, false, true, true);
                }
            }
        }

        /// <summary>
        /// Event handler for buffer ready.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void Microphone_BufferReady(object sender, EventArgs e)
        {
            // Retrieve audio data
            this.MicroPhone.GetData(this.AudioBuffer);

            // Store the audio data in a stream
            this.AudioStream.Write(this.AudioBuffer, 0, this.AudioBuffer.Length);
        }

        /// <summary>
        /// Record button click event handler.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void RecordButton_Click(object sender, EventArgs e)
        {
            // Get audio data in 1/2 second chunks
            this.MicroPhone.BufferDuration = TimeSpan.FromMilliseconds(500);

            // Allocate memory to hold the audio data
            this.AudioBuffer = new byte[this.MicroPhone.GetSampleSizeInBytes(this.MicroPhone.BufferDuration)];

            // Set the stream back to zero in case there is already something in it
            this.AudioStream.SetLength(0);

            // Start recording
            this.MicroPhone.Start();

            this.SetButtonStates(false, true, false, false);
        }

        /// <summary>
        /// Stop button click event.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (this.MicroPhone.State == MicrophoneState.Started)
            {
                // In RECORD mode, user clicked the 
                // stop button to end recording
                this.MicroPhone.Stop();
            }
            else if (this.SoundInstance.State == SoundState.Playing)
            {
                // In PLAY mode, user clicked the 
                // stop button to end playing back
                this.SoundInstance.Stop();
            }

            this.SetButtonStates(true, false, true, true);
        }

        /// <summary>
        /// Play button click event.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (this.AudioStream.Length > 0)
            {
                // Update the UI to reflect that sound is playing
                this.SetButtonStates(false, true, false, false);

                // Play the audio in a new thread so the UI can update.
                Thread soundThread = new Thread(new ThreadStart(this.PlaySound));
                soundThread.Start();
            }
        }

        /// <summary>
        /// Helper method to play sound.
        /// </summary>
        private void PlaySound()
        {
            if (this.SoundInstance != null)
            {
                this.SoundInstance.Dispose();
                this.SoundInstance = null;
            }
            
            if (this.SoundEffect != null)
            {
                this.SoundEffect.Dispose();
                this.SoundEffect = null;
            }

            // Play audio using SoundEffectInstance so we can monitor it's State 
            // and update the UI in the dt_Tick handler when it is done playing.
            this.SoundEffect = new SoundEffect(this.AudioStream.ToArray(), this.MicroPhone.SampleRate, AudioChannels.Mono);
            this.SoundInstance = this.SoundEffect.CreateInstance();
            this.SoundInstance.Play();
            this.IsSoundPlaying = this.SoundInstance.State == SoundState.Playing;
        }

        /// <summary>
        /// Enable or disable buttons in application bar.
        /// </summary>
        /// <param name="recordEnabled">
        /// Flag specifies whether record button is enable.
        /// </param>
        /// <param name="stopEnabled">
        /// Flag specifies whether stop button is enable.
        /// </param>
        /// <param name="playEnabled">
        /// Flag specifies whether play button is enable.
        /// </param>
        /// <param name="sendEnabled">
        /// Flag specifies whether send button is enable.
        /// </param>
        private void SetButtonStates(bool recordEnabled, bool stopEnabled, bool playEnabled, bool sendEnabled)
        {
            (ApplicationBar.Buttons[0] as ApplicationBarIconButton).IsEnabled = recordEnabled;
            (ApplicationBar.Buttons[1] as ApplicationBarIconButton).IsEnabled = stopEnabled;
            (ApplicationBar.Buttons[2] as ApplicationBarIconButton).IsEnabled = playEnabled;
            (ApplicationBar.Buttons[3] as ApplicationBarIconButton).IsEnabled = sendEnabled;
        }

        /// <summary>
        /// Speech Grammars Received handler.
        /// </summary>
        /// <param name="result">
        /// Service Result.
        /// </param>
        private void OnSpeechGrammarsReceived(SpeechServiceResult result)
        {
            Debug.Assert(result != null, "result is null");

            this.RecognizingProgress.Visibility = Visibility.Collapsed;
            //this.RetrievingGrammarsLabel.Visibility = Visibility.Collapsed;
            if (result.Status == Status.Success)
            {
                this.SetButtonStates(true, false, false, false);
                //this.SpeechDomainsList.Visibility = Visibility.Visible;

                this.availableGrammars = result.SpeechResult.Items;
                if (this.availableGrammars == null)
                {
                    return;
                }

                //this.SpeechDomainsList.Items.Clear();

                //if (this.availableGrammars != null)
                //{
                  //  this.availableGrammars.ForEach((item) => this.SpeechDomainsList.Items.Add(item));
                //}
            }
            else
            {
                string error="Error receiving available speech grammars.";
                if (result.Exception != null && result.Exception.Message.Contains("The appId"))
                {
                    // Here we do not show the error message directly because it would expose the appid to users.
                    error = "Error receiving available speech grammars. The Hawaii app Id is invalid!";
                }
                else
                {
                    error = "Error receiving available speech grammars.";
                }


                MessageBox.Show(error, "Error", MessageBoxButton.OK);
                //this.NoGrammarsLabel.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Recognize button click event handler.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void RecognizeButton_Click(object sender, EventArgs e)
        {
            if (this.availableGrammars == null ||
                this.availableGrammars.Count == 0)
            {
                return;
            }

            this.RecognizingProgress.Visibility = Visibility.Visible;

            if (this.AudioStream != null && this.AudioStream.Length != 0)
            {
                SpeechService.RecognizeSpeechAsync(
                HawaiiClient.HawaiiApplicationId,
                   "Dictation",
                this.AudioStream.ToArray(),
                (result) =>
                {
                    this.Dispatcher.BeginInvoke(() => this.OnSpeechRecognitionCompleted(result));
                });
            }
            else
            {
                MessageBox.Show("Invalid speech buffer found. Record speech and try again.", "Error", MessageBoxButton.OK);
            }
        }

        /// <summary>
        /// Speech recognition completed handler.
        /// </summary>
        /// <param name="speechResult">
        /// Service result.
        /// </param>
        private void OnSpeechRecognitionCompleted(SpeechServiceResult speechResult)
        {
            Debug.Assert(speechResult != null, "speechResult is null");

            this.RecognizingProgress.Visibility = Visibility.Collapsed;

            if (speechResult.Status == Status.Success)
            {
                this.SetRecognizedTextListBox(speechResult.SpeechResult.Items);
            }
            else
            {
                if (speechResult.Exception == null)
                {
                    MessageBox.Show("Error recognizing the speech.", "Error", MessageBoxButton.OK);
                }
                else
                {
                    MessageBox.Show(speechResult.Exception.Message, "Error", MessageBoxButton.OK);
                }
            }
        }

        /// <summary>
        /// Delegate method to populate recognition results in the list box.
        /// </summary>
        /// <param name="recognitionResultStrings">
        /// List of recognition results.
        /// </param>
        private void SetRecognizedTextListBox(List<string> recognitionResultStrings)
        {
            if (recognitionResultStrings != null)
            {
                if (recognitionResultStrings.Count == 0)
                {
                    this.RecognizedStringListBox.Items.Add("Empty recognized text is received.");
                }
                else
                {
                    recognitionResultStrings.ForEach((item) => this.RecognizedStringListBox.Items.Add(item));
                }
            }
            else
            {
                this.RecognizedStringListBox.Items.Add("Sorry, unable to recognize speech");
            }
        }

        /// <summary>
        /// Delegate method to populate the grammars in the list box.
        /// </summary>
        private void SetSpeechGrammarsListBox()
        {
            if (this.availableGrammars == null)
            {
                return;
            }

            //this.SpeechDomainsList.Items.Clear();

            //if (this.availableGrammars != null)
            //{
              //  this.availableGrammars.ForEach((item) => this.SpeechDomainsList.Items.Add(item));
            //}
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

        /// <summary>
        /// Clear all menu item menu click event handler.
        /// </summary>
        /// <param name="sender">
        /// Sender of this event.
        /// </param>
        /// <param name="e">
        /// Event arguments.
        /// </param>
        private void ClearAllMenuItem_Click(object sender, EventArgs e)
        {
            this.RecognizedStringListBox.Items.Clear();
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
