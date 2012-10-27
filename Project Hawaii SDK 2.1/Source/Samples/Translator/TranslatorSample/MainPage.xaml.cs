// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -
namespace TranslatorSampleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows;
    using Microsoft.Hawaii;
    using Microsoft.Hawaii.Translator.Client;
    using Microsoft.Phone.Controls;

    /// <summary>
    /// MainPage of this demo application.
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        /// <summary>
        /// The required code to auto detect language both for speak and translate.
        /// </summary>
        private const string DetectedLanguageCode = "";

        /// <summary>
        /// The display name of auto detected language.
        /// </summary>
        private const string DetectedLanguageName = "Detected";

        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            this.VerifyHawaiiIdentity();
            this.BindLanguagePickers();
        }

        #region Page Events
        /// <summary>
        /// Translate button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnTranslate_Click(object sender, RoutedEventArgs e)
        {
            this.StartAsync();

            try
            { 
                this.tbTextTranslatedTo.Text = string.Empty;

                TranslatorService.TranslateAsync(
                    HawaiiClient.AdmClientId,
                    HawaiiClient.AdmClientSecret,
                    this.tbTextTranslatedFrom.Text.Trim(),
                    (this.PickerLanguageTo.SelectedItem as Language).Code,
                    this.OnTranslateComplete,
                    null,                    
                    (this.PickerLanguageFrom.SelectedItem as Language).Code);
            }
            catch (ArgumentNullException ex)
            {
                this.EndAsync();
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Speak button click handler.
        /// </summary>
        /// <param name="sender">Sender object of this event.</param>
        /// <param name="e">Event arguments.</param>
        private void BtnSpeak_Click(object sender, RoutedEventArgs e)
        {
            this.StartAsync();

            try
            {
                TranslatorService.SpeakAsync(
                    HawaiiClient.AdmClientId,
                    HawaiiClient.AdmClientSecret,
                    this.tbTextSpeak.Text.Trim(),
                    this.OnSpeakComplete,
                    null,
                    (this.PickerLanguageSpeakTo.SelectedItem as Language).Code);
            }
            catch (ArgumentNullException ex)
            {
                this.EndAsync();
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Async Callback
        /// <summary>
        /// Async callback of Translate API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnTranslateComplete(TranslateResult result)
        {
            Dispatcher.BeginInvoke(() =>
            {
                this.EndAsync();
                if (result.Status == Status.Success)
                {
                    this.tbTextTranslatedTo.Text = result.TextTranslated;
                }
                else
                {
                    MessageBox.Show(result.Exception.Message);
                }
            });
        }

        /// <summary>
        /// Async callback of GetLanguagesForSpeak API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnGetLanguagesForSpeakComplete(GetLanguagesForSpeakResult result)
        {
            Dispatcher.BeginInvoke(() =>
            {
                this.EndAsync();

                if (result.Status == Status.Success)
                {
                    List<Language> languages = new List<Language>(result.SupportedLanguages);
                    languages.Insert(0, new Language() { Name = DetectedLanguageName, Code = DetectedLanguageCode });

                    this.PickerLanguageSpeakTo.ItemsSource = languages;
                    this.PickerLanguageSpeakTo.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show(result.Exception.Message);
                }
            });
        }

        /// <summary>
        /// Async callback of GetLanguagesForTranslate API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnGetLanguagesForTranslateComplete(GetLanguagesForTranslateResult result)
        {
            Dispatcher.BeginInvoke(() =>
            {
                if (result.Status == Status.Success)
                {
                    List<Language> languagesFrom = new List<Language>(result.SupportedLanguages);
                    languagesFrom.Insert(0, new Language() { Name = DetectedLanguageName, Code = DetectedLanguageCode });

                    List<Language> languagesTo = new List<Language>(result.SupportedLanguages);

                    this.PickerLanguageFrom.ItemsSource = languagesFrom;
                    this.PickerLanguageTo.ItemsSource = languagesTo;

                    // Might want to save the last selection.
                    this.PickerLanguageFrom.SelectedIndex = 0;
                    this.PickerLanguageTo.SelectedIndex = 8;


                    TranslatorService.GetLanguagesForSpeakAsync(
                        HawaiiClient.AdmClientId,
                        HawaiiClient.AdmClientSecret,
                        this.OnGetLanguagesForSpeakComplete,
                        null);
                }
                else
                {
                    this.EndAsync();
                    MessageBox.Show(result.Exception.Message);
                }
            });
        }

        /// <summary>
        /// Async callback of Speak API.
        /// </summary>
        /// <param name="result">The service call result.</param>
        private void OnSpeakComplete(SpeakResult result)
        {
            Dispatcher.BeginInvoke(() =>
            {
                this.EndAsync();

                if (result.Status == Status.Success)
                {
                    MemoryStream stream = new MemoryStream(result.Audio);
                    if (stream != null)
                    {
                        var effect = Microsoft.Xna.Framework.Audio.SoundEffect.FromStream(stream);
                        Microsoft.Xna.Framework.FrameworkDispatcher.Update();
                        effect.Play();
                    }
                }
                else
                {
                    MessageBox.Show(result.Exception.Message);
                }
            });
        }
        #endregion 

        #region Help method
        /// <summary>
        /// Bind the supported languages for translation and speech.
        /// </summary>
        private void BindLanguagePickers()
        {
            this.StartAsync();
            try
            {
                TranslatorService.GetLanguagesForTranslateAsync(
                    HawaiiClient.AdmClientId,
                    HawaiiClient.AdmClientSecret,
                    this.OnGetLanguagesForTranslateComplete,
                    null);
            }
            catch (ArgumentNullException ex)
            {
                this.EndAsync();
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Verify that the Hawaii application Id is set correctly.
        /// </summary>
        private void VerifyHawaiiIdentity()
        {
            if (string.IsNullOrEmpty(HawaiiClient.AdmClientId) || 
                string.IsNullOrEmpty(HawaiiClient.AdmClientSecret))
            {
                MessageBox.Show("The Adm client Id or client secret is missing. Please consult the \"Project Hawaii Installation Guide\" on how to obtain credentials");
                throw new Exception("Credentials are not set, exiting application");
            }
        }

        /// <summary>
        /// Help method to set the page into async call mode.
        /// </summary>
        private void StartAsync()
        {
            this.Opacity = 0.7;
            this.IsEnabled = false;
            this.progressBar.Visibility = System.Windows.Visibility.Visible;
        }

        /// <summary>
        /// Help method to set the page into none async call mode.
        /// </summary>
        private void EndAsync()
        {
            this.Opacity = 1;
            this.IsEnabled = true;
            this.progressBar.Visibility = System.Windows.Visibility.Collapsed;
        }
        #endregion Help method
    }
}