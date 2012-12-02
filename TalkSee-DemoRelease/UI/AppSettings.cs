using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO.IsolatedStorage;
using System.Diagnostics;

namespace SpeechToTextSampleApp
{
    public class AppSettings
    {
        // Our isolated storage settings
        IsolatedStorageSettings isolatedStore;

        // The isolated storage key names of our settings
        const string UsernameSettingKeyName = "UsernameSetting";
        const string NumberSettingKeyName = "NumberSetting";
        const string StatusSettingKeyName = "StatusSetting";
        const string OldUsernameSettingKeyName = "OldUsernameSetting";
        const string OldStatusSettingKeyName = "OldStatusSetting";
        const string OldPortSettingKeyName = "OldPortSetting";
        const string PortSettingKeyName = "PortSetting";
        const string TimeStampSettingKeyName = "TimeStampSetting";

        // The default value of our settings
        const string OldUsernameSettingDefault = "Aaron";
        const string UsernameSettingDefault = "Aaron";
        const string NumberSettingDefault = "123-456-7890";
        const string StatusSettingDefault = "available";
        const string OldStatusSettingDefault = "available";
        const string OldPortSettingDefault = "9001";
        const string PortSettingDefault = "9001";
        const string TimeStampSettingDefault = "0:00";

        

        /// <summary>
        /// Constructor that gets the application settings.
        /// </summary>
        public AppSettings()
        {
            try
            {
                // Get the settings for this application.
                isolatedStore = IsolatedStorageSettings.ApplicationSettings;

            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception while using IsolatedStorageSettings: " + e.ToString());
            }
        }

        /// <summary>
        /// Update a setting value for our application. If the setting does not
        /// exist, then add the setting.
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddOrUpdateValue(string Key, Object value)
        {
            bool valueChanged = false;

            // If the key exists
            if (isolatedStore.Contains(Key))
            {
                // If the value has changed
                if (isolatedStore[Key] != value)
                {
                    // Store the new value
                    isolatedStore[Key] = value;
                    valueChanged = true;
                }
            }
            // Otherwise create the key.
            else
            {
                isolatedStore.Add(Key, value);
                valueChanged = true;
            }

            return valueChanged;
        }


        /// <summary>
        /// Get the current value of the setting, or if it is not found, set the 
        /// setting to the default setting.
        /// </summary>
        /// <typeparam name="valueType"></typeparam>
        /// <param name="Key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public valueType GetValueOrDefault<valueType>(string Key, valueType defaultValue)
        {
            valueType value;

            // If the key exists, retrieve the value.
            if (isolatedStore.Contains(Key))
            {
                value = (valueType)isolatedStore[Key];
            }
            // Otherwise, use the default value.
            else
            {
                value = defaultValue;
            }

            return value;
        }


        /// <summary>
        /// Save the settings.
        /// </summary>
        public void Save()
        {
            isolatedStore.Save();
        }

        /// <summary>
        /// Property to get and set a Username Setting Key.
        /// </summary>
        public string UsernameSetting
        {
            get
            {
                return GetValueOrDefault<string>(UsernameSettingKeyName, UsernameSettingDefault);
            }
            set
            {
                AddOrUpdateValue(UsernameSettingKeyName, value);
                Save();
            }
        }

        /// <summary>
        /// Property to get and set a Password Setting Key.
        /// </summary>
        public string NumberSetting
        {
            get
            {
                return GetValueOrDefault<string>(NumberSettingKeyName, NumberSettingDefault);
            }
            set
            {
                AddOrUpdateValue(NumberSettingKeyName, value);
                Save();
            }
        }

        /// <summary>
        /// Property to get and set a Password Setting Key.
        /// </summary>
        public string StatusSetting
        {
            get
            {
                return GetValueOrDefault<string>(StatusSettingKeyName, StatusSettingDefault);
            }
            set
            {
                AddOrUpdateValue(StatusSettingKeyName, value);
                Save();
            }
        }

        public string PortSetting
        {
            get
            {
                return GetValueOrDefault<string>(PortSettingKeyName, PortSettingDefault);
            }
            set
            {
                AddOrUpdateValue(PortSettingKeyName, value);
                Save();
            }
        }

        public string TimeStampSetting
        {
            get
            {
                return GetValueOrDefault<string>(TimeStampSettingKeyName, TimeStampSettingDefault);
            }
            set
            {
                AddOrUpdateValue(TimeStampSettingKeyName, value);
                Save();
            }
        }

        /// <summary>
        /// Property to get and set a Password Setting Key.
        /// </summary>
        public string OldStatusSetting
        {
            get
            {
                return GetValueOrDefault<string>(OldStatusSettingKeyName, OldStatusSettingDefault);
            }
            set
            {
                AddOrUpdateValue(OldStatusSettingKeyName, value);
                Save();
            }
        }

        public string OldPortSetting
        {
            get
            {
                return GetValueOrDefault<string>(OldPortSettingKeyName, OldPortSettingDefault);
            }
            set
            {
                AddOrUpdateValue(OldPortSettingKeyName, value);
                Save();
            }
        }

        public string OldUsernameSetting 
        {
            get
            {
                return GetValueOrDefault<string>(OldUsernameSettingKeyName, OldUsernameSettingDefault);
            }
            set
            {
                AddOrUpdateValue(OldUsernameSettingKeyName, value);
                Save();
            }
        }
    }
}
