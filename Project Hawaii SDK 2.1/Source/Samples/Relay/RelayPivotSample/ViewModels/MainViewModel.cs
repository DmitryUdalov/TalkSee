// -
// <copyright file="MainViewModel.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using RelaySampleAppPivot.Model;

namespace RelaySampleAppPivot
{
    /// <summary>
    /// ViewModel class for RelayPivot application.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        private RelayContext relayContext;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        /// <summary>
        /// Gets a value indicating whether the data is already loaded.
        /// </summary>
        public bool IsDataLoaded { get;  private set; }

        /// <summary>
        /// Gets or sets Relay data context.
        /// </summary>
        public RelayContext RelayContext
        {
            get
            {
                return this.relayContext;
            }

            set
            {
                if (value != this.relayContext)
                {
                    this.relayContext = value;
                    this.NotifyPropertyChanged("RelayContext");
                }
            }
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