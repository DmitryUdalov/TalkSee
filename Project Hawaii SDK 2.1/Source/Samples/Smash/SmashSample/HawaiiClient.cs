// -
// <copyright file="HawaiiClient.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

namespace SmashSampleApp
{
    using System.Windows;

    /// <summary>
    /// HawaiiClient stores the Hawaii client identity.
    /// </summary>
    /// <remarks>
    /// Please consult the "Hawaii Installation Guide.docx" on how to obtain credentials
    /// </remarks>
    public static class HawaiiClient
    {
        /// <summary>
        /// The Azure data market client Id.
        /// </summary>
        public const string AdmClientId = "";

        /// <summary>
        /// The Azure data market client secret.
        /// </summary>
        public const string AdmClientSecret = "";

        /// <summary>
        /// The application secret for SMASH clients.
        /// This must be a stable GUID only known to the application. Use a GUID generator to obtain a new value.
        /// </summary>
        public const string ApplicationSecret = "";
    }
}
