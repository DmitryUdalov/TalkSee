// -
// <copyright file="RelayContext.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Hawaii.Relay.Client;

namespace RelaySampleAppPivot.Model
{
    /// <summary>
    /// Model class for Model View ViewModel Pattern.
    /// </summary>
    public class RelayContext : INotifyPropertyChanged
    {
        private Endpoint endpoint;

        private Group group;

        private ObservableCollection<Message> messages;

        private string recipients;

        private string messageContent;

        private string groupIdToBeJoined;
        
        /// <summary>
        /// Initializes a new instance of the RelayContext class.
        /// </summary>
        public RelayContext()
        {
            this.messageContent = "Welcome to Window Mobile 7";
            this.messages = new ObservableCollection<Message>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
               
        /// <summary>
        /// Gets or sets the Endpoint.
        /// </summary>
        public Endpoint Endpoint
        {
            get
            {
                return this.endpoint;
            }

            set
            {
                if (value != this.endpoint)
                {
                    this.endpoint = value;
                    this.NotifyPropertyChanged("EndpointId");
                }
            }
        }

        /// <summary>
        /// Gets the EndpointId from Endpoint obejct.
        /// </summary>
        public string EndpointId
        {
            get
            {
                if (this.endpoint == null)
                {
                    return "No endpoint is active.";
                }
                else
                {
                    return this.endpoint.RegistrationId;
                }
            }
        }
                       
        /// <summary>
        /// Gets or sets the Group.
        /// </summary>
        public Group Group
        {
            get
            {
                return this.group;
            }

            set
            {
                if (value != this.group)
                {
                    this.group = value;
                    this.NotifyPropertyChanged("GroupId");
                }
            }
        }

        /// <summary>
        /// Gets the GroupId from Group obejct.
        /// </summary>
        public string GroupId
        {
            get
            {
                if (this.group == null)
                {
                    return "No group is created.";
                }
                else
                {
                    return this.group.RegistrationId;
                }
            }
        }

        /// <summary>
        /// Gets the EndpointGroupId from Endpoint object.
        /// </summary>
        public string EndpointGroupId
        {
            get
            {
                if (this.endpoint == null ||
                    this.endpoint.Groups.Count == 0)
                {
                    return "No group is joined";
                }
                else
                {
                    return this.endpoint.Groups[0].RegistrationId;
                }
            }
        }

        /// <summary>
        /// Gets or sets the GroupIdToBeJoined.
        /// </summary>
        public string GroupIdToBeJoined
        {
            get
            {
                return this.groupIdToBeJoined;
            }

            set
            {
                if (value != this.groupIdToBeJoined)
                {
                    this.groupIdToBeJoined = value;

                    // Inform UI to update the appropriate controls.
                    this.NotifyPropertyChanged("GroupIdToBeJoined");
                }
            }
        }

        /// <summary>
        /// Gets or sets the Message Content.
        /// </summary>
        public string MessageContent
        {
            get
            {
                return this.messageContent;
            }

            set
            {
                this.messageContent = value;

                // Inform UI to update the appropriate controls.
                this.NotifyPropertyChanged("MessageContent");
            }
        }
  
        /// <summary>
        /// Gets or sets the Recipients value.
        /// </summary>
        public string Recipients
        {
            get
            {
                return this.recipients;
            }

            set
            {
                this.recipients = value;

                // Inform UI to update the appropriate controls.
                this.NotifyPropertyChanged("Recipients");
            }
        }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public ObservableCollection<Message> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                if (value != this.messages)
                {
                    this.messages = value;
                    this.NotifyPropertyChanged("Messages");
                }
            }
        }

        /// <summary>
        /// Helper function to create a relay context.
        /// </summary>
        /// <returns>A valid relay context object.</returns>
        public static RelayContext CreateObject()
        {
            RelayContext dataContext = new RelayContext();
            dataContext.ReadFromStorage();
            return dataContext;
        }

        /// <summary>
        /// Helper method to join a group.
        /// </summary>
        /// <param name="group">Group to join.</param>
        public void JoinGroup(Group group)
        {
            Debug.Assert(group != null, "group is null");
            Debug.Assert(this.Endpoint != null, "endpoint is null");
                        
            // Clear and add group to be joined.
            this.Endpoint.Groups.Clear();
            this.Endpoint.Groups.Add(group);

            // Set the recipient id.
            this.Recipients = group.RegistrationId;

            // Inform UI to update the appropriate controls.
            this.NotifyPropertyChanged("EndpointGroupId");
            this.NotifyPropertyChanged("Recipients");
        }

        /// <summary>
        /// A helper method to leave a group.
        /// </summary>
        /// <param name="group">Group to leave.</param>
        public void LeaveGroup(Group group)
        {
            Debug.Assert(group != null, "group is null");
            Debug.Assert(this.Endpoint != null, "endpoint is null");
            Debug.Assert(this.Endpoint.Groups.Count != 0, "joined group count is zero");
            
            // Clear the joined groups of the endpoint.
            this.Endpoint.Groups.Clear();

            // Set the recipients to empty.
            this.Recipients = string.Empty;

            // Inform UI to update the appropriate controls.
            this.NotifyPropertyChanged("EndpointGroupId");
            this.NotifyPropertyChanged("Recipients");
        }

        /// <summary>
        /// Save the relay context to the storage.
        /// </summary>
        public void SaveToStorage()
        {
            try
            {
                RelayStorage.SaveEndpoint(this.endpoint);

                Groups groups = new Groups();
                groups.Add(this.group);

                RelayStorage.SaveGroups(groups);
                List<Message> messages = new List<Message>();
                foreach (Message message in this.messages)
                {
                    messages.Add(message);
                }

                RelayStorage.SaveMessages(messages);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Read the relay context from storage.
        /// </summary>
        public void ReadFromStorage()
        {
            try
            {
                this.Endpoint = RelayStorage.ReadEndpoint();
                Groups groups = RelayStorage.ReadGroups();
                if (groups != null && groups.Count > 0)
                {
                    this.Group = groups[0];
                }

                List<Message> messages = RelayStorage.ReadMessages();
                foreach (Message message in messages)
                {
                    this.Messages.Add(message);
                }

                if (this.Group != null)
                {
                    this.GroupIdToBeJoined = this.Group.RegistrationId.ToString();
                }

                if (this.Endpoint.Groups != null &&
                    this.Endpoint.Groups.Count > 0)
                {
                    this.Recipients = this.Endpoint.Groups[0].RegistrationId.ToString();
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Property change event handler for RelayDataContext class.
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
