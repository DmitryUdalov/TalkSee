//-----------------------------------------------------------------------
// <copyright file="App.xaml.cs" company="Microsoft">
//     Copyright (c) robgruen, . All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace PathPredictionSample
{
    using System;
    using System.Diagnostics;

    using System.Windows;
    using System.Windows.Navigation;

    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Shell;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Avoid double-initialization
        /// </summary>
        private bool phoneApplicationInitialized = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            // Global handler for uncaught exceptions. 
            this.UnhandledException += this.Application_UnhandledException;

            // Show graphics profiling information while debugging.
            if (Debugger.IsAttached)
            {
                // Display the current frame rate counters.
                Application.Current.Host.Settings.EnableFrameRateCounter = true;

                // Show the areas of the app that are being redrawn in each frame.
                // Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Enable non-production analysis visualization mode, 
                // which shows areas of a page that are being GPU accelerated with a colored overlay.
                // Application.Current.Host.Settings.EnableCacheVisualization = true;
            }

            // Standard Silverlight initialization
            this.InitializeComponent();

            // Phone-specific initialization
            this.InitializePhoneApplication();
        }

        /// <summary>
        /// Gets the root <see cref="T:PhoneApplicationFrame"/> of the application.
        /// </summary>
        /// <returns>The root <see cref="T:PhoneApplicationFrame"/> of the application..</returns>
        public PhoneApplicationFrame RootFrame
        {
            get;
            private set;
        }

        /// <summary>
        /// Handles the <see cref="E:Windows.Phone.Shell.PhoneApplicationService.Launching"/> event of the application control.
        /// </summary>
        /// <remarks>This code will not execute when the application is reactivated.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Microsoft.Phone.Shell.LaunchingEventArgs"/> instance containing the event data.</param>
        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
        }

        /// <summary>
        /// Handles the <see cref="E:Windows.Phone.Shell.PhoneApplicationService.Activated"/> event of the application control.
        /// </summary>
        /// <remarks>This code will not execute when the application is first launched.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Microsoft.Phone.Shell.ActivatedEventArgs"/> instance containing the event data.</param>
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the <see cref="E:Windows.Phone.Shell.PhoneApplicationService.Deactivated"/> event of the application control.
        /// </summary>
        /// <remarks>This code will not execute when the application is closing.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Microsoft.Phone.Shell.DeactivatedEventArgs"/> instance containing the event data.</param>
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the <see cref="E:Windows.Phone.Shell.PhoneApplicationService.Closing"/> event of the application control.
        /// </summary>
        /// <remarks>This code will not execute when the application is deactivated.</remarks>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="Microsoft.Phone.Shell.ClosingEventArgs"/> instance containing the event data.</param>
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
        }

        /// <summary>
        /// Handles the <see cref="E:Microsoft.Phone.Controls.PhoneApplicationFrame.NavigationFailed"/> event of the root frame control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Navigation.NavigationFailedEventArgs"/> instance containing the event data.</param>
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                // A navigation has failed; break into the debugger
                Debugger.Break();
            }
        }

        /// <summary>
        /// Handles the <see cref="E:System.Windows.Application.UnhandledException"/> event.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.ApplicationUnhandledExceptionEventArgs"/> instance containing the event data.</param>
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                Debugger.Break();
            }
        }

        /// <summary>
        /// Initializes the phone application.
        /// </summary>
        /// <remarks>Do not add any additional code to this method.</remarks>
        private void InitializePhoneApplication()
        {
            if (this.phoneApplicationInitialized)
            {
                return;
            }

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            this.RootFrame = new PhoneApplicationFrame();
            this.RootFrame.Navigated += this.CompleteInitializePhoneApplication;

            // Handle navigation failures
            this.RootFrame.NavigationFailed += this.RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            this.phoneApplicationInitialized = true;
        }

        /// <summary>
        /// Completes the initialize phone application.
        /// </summary>
        /// <remarks>Do not add any additional code to this method.</remarks>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.Navigation.NavigationEventArgs"/> instance containing the event data.</param>
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
            if (this.RootVisual != this.RootFrame)
            {
                this.RootVisual = this.RootFrame;
            }

            // Remove this handler since it is no longer needed
            this.RootFrame.Navigated -= this.CompleteInitializePhoneApplication;
        }
    }
}