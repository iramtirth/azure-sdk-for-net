// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Azure;
    using Management;
    using ContainerRegistry;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result of a request to check the availability of a container
    /// registry name.
    /// </summary>
    public partial class RegistryNameStatus
    {
        /// <summary>
        /// Initializes a new instance of the RegistryNameStatus class.
        /// </summary>
        public RegistryNameStatus() { }

        /// <summary>
        /// Initializes a new instance of the RegistryNameStatus class.
        /// </summary>
        /// <param name="nameAvailable">The value that indicates whether the
        /// name is available.</param>
        /// <param name="reason">If any, the reason that the name is not
        /// available.</param>
        /// <param name="message">If any, the error message that provides more
        /// detail for the reason that the name is not available.</param>
        public RegistryNameStatus(bool? nameAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary>
        /// Gets or sets the value that indicates whether the name is
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "nameAvailable")]
        public bool? NameAvailable { get; set; }

        /// <summary>
        /// Gets or sets if any, the reason that the name is not available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets if any, the error message that provides more detail
        /// for the reason that the name is not available.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
