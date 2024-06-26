// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// The Defender for DevOps for Azure DevOps offering
    /// </summary>
    [Newtonsoft.Json.JsonObject("DefenderForDevOpsAzureDevOps")]
    public partial class DefenderForDevOpsAzureDevOpsOffering : CloudOffering
    {
        /// <summary>
        /// Initializes a new instance of the DefenderForDevOpsAzureDevOpsOffering class.
        /// </summary>
        public DefenderForDevOpsAzureDevOpsOffering()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefenderForDevOpsAzureDevOpsOffering class.
        /// </summary>

        /// <param name="description">The offering description.
        /// </param>
        public DefenderForDevOpsAzureDevOpsOffering(string description = default(string))

        : base(description)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}