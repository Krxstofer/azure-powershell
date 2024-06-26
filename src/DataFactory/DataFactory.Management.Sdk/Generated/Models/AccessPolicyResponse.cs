// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Get Data Plane read only token response definition.
    /// </summary>
    public partial class AccessPolicyResponse
    {
        /// <summary>
        /// Initializes a new instance of the AccessPolicyResponse class.
        /// </summary>
        public AccessPolicyResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AccessPolicyResponse class.
        /// </summary>

        /// <param name="policy">The user access policy.
        /// </param>

        /// <param name="accessToken">Data Plane read only access token.
        /// </param>

        /// <param name="dataPlaneUrl">Data Plane service base URL.
        /// </param>
        public AccessPolicyResponse(UserAccessPolicy policy = default(UserAccessPolicy), string accessToken = default(string), string dataPlaneUrl = default(string))

        {
            this.Policy = policy;
            this.AccessToken = accessToken;
            this.DataPlaneUrl = dataPlaneUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the user access policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policy")]
        public UserAccessPolicy Policy {get; set; }

        /// <summary>
        /// Gets or sets data Plane read only access token.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accessToken")]
        public string AccessToken {get; set; }

        /// <summary>
        /// Gets or sets data Plane service base URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataPlaneUrl")]
        public string DataPlaneUrl {get; set; }
    }
}