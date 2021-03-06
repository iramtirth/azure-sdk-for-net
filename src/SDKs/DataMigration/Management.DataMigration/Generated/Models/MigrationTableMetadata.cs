// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metadata for tables selected in migration project
    /// </summary>
    public partial class MigrationTableMetadata
    {
        /// <summary>
        /// Initializes a new instance of the MigrationTableMetadata class.
        /// </summary>
        public MigrationTableMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationTableMetadata class.
        /// </summary>
        /// <param name="sourceTableName">Source table name</param>
        /// <param name="targetTableName">Target table name</param>
        public MigrationTableMetadata(string sourceTableName = default(string), string targetTableName = default(string))
        {
            SourceTableName = sourceTableName;
            TargetTableName = targetTableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets source table name
        /// </summary>
        [JsonProperty(PropertyName = "sourceTableName")]
        public string SourceTableName { get; private set; }

        /// <summary>
        /// Gets target table name
        /// </summary>
        [JsonProperty(PropertyName = "targetTableName")]
        public string TargetTableName { get; private set; }

    }
}
