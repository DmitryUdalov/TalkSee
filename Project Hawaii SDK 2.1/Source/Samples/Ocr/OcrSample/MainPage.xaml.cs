// -
// <copyright file="MainPage.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -
using System;
using System.Linq;
using System.Diagnostics;
using System.Windows;
using Microsoft.Hawaii;
using Microsoft.Hawaii.Ocr.Client;
using Microsoft.Phone.Controls;
using OcrSampleApp.Controls;
using OcrSampleApp.Data;
using OcrSampleApp.Utils;
using OcrSampleApp.ViewModels;
using Microsoft.Xna.Framework.Media;

namespace OcrSampleApp
{
    /// <summary>
    /// MainPage class contains the code behind for the MainPage user control.
    /// The MainPage user control is the main user control used by this application.
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        private OcrData ocrData;
        private OcrConversionStateManager ocrConversionStateManager;

        /// <summary>
        /// Initializes a new instance of the MainPage class.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            CopyDefaultImage();

            this.VerifyHawaiiIdentity();

            this.ocrData = OcrData.Instance;
            this.ocrData.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.OcrData_PropertyChanged);

            this.ocrConversionStateManager = OcrConversionStateManager.Instance;
            this.ocrConversionStateManager.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.ConversionStateManager_PropertyChanged);

            this.mainPivot.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MainPivot_SelectionChanged);
        }

        /// <summary>
        /// Copies default image for use in the Emulator.
        /// </summary>
        private void CopyDefaultImage()
        {
            const string PicName =  "helloworld.jpg";
            MediaLibrary myMediaLibrary = new MediaLibrary();

            if (myMediaLibrary.SavedPictures.Where(x => x.Name == PicName).FirstOrDefault() == null)
            {
                Uri myUri = new Uri(@"Images/" + PicName, UriKind.Relative);

                System.IO.Stream photoStream = App.GetResourceStream(myUri).Stream;
                byte[] buffer = new byte[photoStream.Length];

                photoStream.Read(buffer, 0, Convert.ToInt32(photoStream.Length));
                myMediaLibrary.SavePicture(PicName, buffer);
            }


        }

        /// <summary>
        /// This method is called when the hardware back key is pressed.
        /// </summary>
        /// <param name="e">
        /// Allows us to cancel the request to indicate that it was handled by the application.
        /// </param>
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            // If we are currently showing a pivot item other than the main one we'll react 
            // to the back button by sliding to the main pivot item and in the same time we'll 
            // prevent the app from exiting.
            if (this.mainPivot.SelectedIndex > 0)
            {
                this.mainPivot.SelectedIndex = 0;
                e.Cancel = true;
            }
        }

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

        private void ConversionStateManager_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "OcrConversionState")
            {
                if (this.ocrConversionStateManager.OcrConversionState != OcrConversionState.Converting)
                {
                    this.Dispatcher.BeginInvoke(() => { this.mainPivot.SelectedIndex = 2; });
                }

                this.UpdateApplicationBarVisibility();
            }
        }

        private void MainPivot_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            this.UpdateApplicationBarVisibility();
        }

        private void UpdateApplicationBarVisibility()
        {
            this.ApplicationBar.IsVisible = this.mainPivot.SelectedIndex == 2 && this.ocrConversionStateManager.OcrConversionState == OcrConversionState.ConversionOK;
        }

        private void OcrData_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PhotoStream")
            {
                if (this.ocrData.PhotoStream != null)
                {
                    this.UpdateAfterPhotoStreamChanged();
                }
            }
        }

        private void UpdateAfterPhotoStreamChanged()
        {
            this.EnsurePhotoAreaExists();
            this.EnsureTextAreaExists();
            this.StartOcrConversion();
        }

        private void StartOcrConversion()
        {
            OcrService.RecognizeImageAsync(
                HawaiiClient.HawaiiApplicationId,
                OcrClientUtils.GetPhotoBits(this.ocrData.PhotoStream),
                (output) => 
                {
                    // This section defines the body of what is known as an anonymous method. 
                    // This anonymous method is the callback method 
                    // called on the completion of the OCR process.
                    // Using Dispatcher.BeginInvoke ensures that 
                    // OnOcrCompleted is invoked on the Main UI thread.
                    this.Dispatcher.BeginInvoke(() => OnOcrCompleted(output)); 
                });

            this.ocrConversionStateManager.OcrConversionState = OcrConversionState.Converting;
            this.Dispatcher.BeginInvoke(() => { this.mainPivot.SelectedIndex = 1; });
        }

        private void OnOcrCompleted(OcrServiceResult result)
        {
            Debug.Assert(result != null, "result is null");

            if (result.Status == Status.Success)
            {
                this.ocrData.SetOcrResult(result.OcrResult.OcrTexts);

                if (this.ocrData.GetWordCount() > 0)
                {
                    this.ocrConversionStateManager.OcrConversionState = OcrConversionState.ConversionOK;
                }
                else
                {
                    this.ocrConversionStateManager.OcrConversionState = OcrConversionState.ConversionEmpty;
                }
            }
            else
            {
                this.ocrConversionStateManager.OcrConversionState = OcrConversionState.ConversionError;
                this.ocrConversionStateManager.OcrConversionErrorMessage = result.Exception.Message;
            }
        }

        private void EnsurePhotoAreaExists()
        {
            if (this.mainPivot.Items.Count < 2)
            {
                PivotItem photoAreaPivot = new PivotItem();
                photoAreaPivot.Margin = new Thickness(0);
                photoAreaPivot.Header = "Photo";
                this.mainPivot.Items.Add(photoAreaPivot);

                photoAreaPivot.Content = new PhotoArea();
            }
        }

        private void EnsureTextAreaExists()
        {
            if (this.mainPivot.Items.Count < 3)
            {
                PivotItem textAreaPivot = new PivotItem();
                textAreaPivot.Margin = new Thickness(0);
                textAreaPivot.Header = "Text";
                this.mainPivot.Items.Add(textAreaPivot);

                textAreaPivot.Content = new TextArea();
            }
        }

        private void ApBarSimpleMode_Click(object sender, EventArgs e)
        {
            this.SetTextAreaMode(TextViewMode.Simple);
        }

        private void AppBarDetailedMode_Click(object sender, EventArgs e)
        {
            this.SetTextAreaMode(TextViewMode.Detailed);
        }

        private void SetTextAreaMode(TextViewMode textViewMode)
        {
            if (this.mainPivot.Items.Count >= 3)
            {
                PivotItem textAreaPivot = (PivotItem)this.mainPivot.Items[2];
                TextArea textArea = (TextArea)textAreaPivot.Content;
                TextAreaViewModel textAreaViewModel = (TextAreaViewModel)textArea.DataContext;
                textAreaViewModel.TextViewMode = textViewMode;
            }
        }
    }
}
