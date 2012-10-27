// -
// <copyright file="MainPageViewModel.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System.ComponentModel;

namespace RendezvousSampleApp
{
    /// <summary>
    /// ViewModel class for RelayPivot application.
    /// </summary>
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private NameRegistrationContext nameRegistrationContext;

        /// <summary>
        /// Initializes a new instance of the MainPageViewModel class.
        /// </summary>
        public MainPageViewModel()
        {
            this.IsDataLoaded = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets a value indicating whether the data is already loaded.
        /// </summary>
        public bool IsDataLoaded { get; private set; }

        /// <summary>
        /// Gets or sets a NameRegistrationContext.
        /// </summary>
        public NameRegistrationContext NameRegistrationContext
        {
            get
            {
                return this.nameRegistrationContext;
            }

            set
            {
                if (value != this.nameRegistrationContext)
                {
                    this.nameRegistrationContext = value;
                    this.NotifyPropertyChanged("NameRegistrationContext");
                }
            }
        }
        
        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.NameRegistrationContext = new NameRegistrationContext();
            this.IsDataLoaded = true;
        }

        /// <summary>
        /// Notification handler for the MainViewModel class.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}