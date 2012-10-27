// -
// <copyright file="MessageConverter.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using Microsoft.Hawaii.Relay.Client;

namespace RelaySampleAppPivot.Model
{
    /// <summary>
    /// Converter converts a Message object to list item.
    /// </summary>
    public class MessageConverter : IValueConverter
    {
        /// <summary>
        /// Converts the source data (value) that is a long representing some data length 
        /// expressed in bytes before passing it to the target of a data binding for display in the UI.
        /// </summary>
        /// <param name="value">
        /// The source data being passed to the target.
        /// A long representing some data length expressed in bytes.
        /// </param>
        /// <param name="targetType">
        /// The type of data expected by the target dependency property.
        /// </param>
        /// <param name="parameter">
        /// It will be ignored by this converter.
        /// </param>
        /// <param name="culture">
        /// The culture of the conversion. Ignored by this converter.
        /// </param>
        /// <returns>
        /// Returns a RotateTransform a string that is the representation of the given length expressed in kilo bytes.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Message message = (Message)value;
            return Encoding.Unicode.GetString(message.Body, 0, message.Body.Length);
        }

        /// <summary>
        /// The ConvertBack is not implemented for this converter. 
        /// ConvertBack will throw NotImplementedException if invoked.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
