﻿// ----------------------------------------------------------
// <copyright file="GetLanguagesForSpeakResponse.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// ----------------------------------------------------------

namespace Microsoft.Hawaii.Translator.Client
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Response for the GetLanguagesForSpeak method.
    /// </summary>
    [DataContract]
    public class GetLanguagesForSpeakResponse
    {
        /// <summary>
        /// Gets or sets the supported languages for speak.
        /// </summary>
        [DataMember]
        public Language[] SupportedLanguages { get; set; }
    }
}
