// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Alert processing rule properties supported by patch.
    /// </summary>
    public partial class PatchProperties
    {
        /// <summary>
        /// Initializes a new instance of the PatchProperties class.
        /// </summary>
        public PatchProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchProperties class.
        /// </summary>

        /// <param name="enabled">Indicates if the given alert processing rule is enabled or disabled.
        /// </param>
        public PatchProperties(bool? enabled = default(bool?))

        {
            this.Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets indicates if the given alert processing rule is enabled or
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled {get; set; }
    }
}