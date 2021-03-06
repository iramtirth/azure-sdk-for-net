// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of available upgrades for compute pools.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedClusterUpgradeProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterUpgradeProfile
        /// class.
        /// </summary>
        public ManagedClusterUpgradeProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterUpgradeProfile
        /// class.
        /// </summary>
        /// <param name="controlPlaneProfile">The list of available upgrade
        /// versions for the control plane.</param>
        /// <param name="agentPoolProfiles">The list of available upgrade
        /// versions for agent pools.</param>
        /// <param name="id">Id of upgrade profile.</param>
        /// <param name="name">Name of upgrade profile.</param>
        /// <param name="type">Type of upgrade profile.</param>
        public ManagedClusterUpgradeProfile(ManagedClusterPoolUpgradeProfile controlPlaneProfile, IList<ManagedClusterPoolUpgradeProfile> agentPoolProfiles, string id = default(string), string name = default(string), string type = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            ControlPlaneProfile = controlPlaneProfile;
            AgentPoolProfiles = agentPoolProfiles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of upgrade profile.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of upgrade profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of upgrade profile.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the list of available upgrade versions for the control
        /// plane.
        /// </summary>
        [JsonProperty(PropertyName = "properties.controlPlaneProfile")]
        public ManagedClusterPoolUpgradeProfile ControlPlaneProfile { get; set; }

        /// <summary>
        /// Gets or sets the list of available upgrade versions for agent
        /// pools.
        /// </summary>
        [JsonProperty(PropertyName = "properties.agentPoolProfiles")]
        public IList<ManagedClusterPoolUpgradeProfile> AgentPoolProfiles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ControlPlaneProfile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ControlPlaneProfile");
            }
            if (AgentPoolProfiles == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AgentPoolProfiles");
            }
            if (ControlPlaneProfile != null)
            {
                ControlPlaneProfile.Validate();
            }
            if (AgentPoolProfiles != null)
            {
                foreach (var element in AgentPoolProfiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
