// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Describes an Azure resource with kind
    /// </summary>
    public partial class KindAutoGenerated
    {
        /// <summary>
        /// Initializes a new instance of the KindAutoGenerated class.
        /// </summary>
        public KindAutoGenerated()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KindAutoGenerated class.
        /// </summary>

        /// <param name="kind">Kind of the resource
        /// </param>
        public KindAutoGenerated(string kind = default(string))

        {
            this.Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets kind of the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind {get; set; }
    }
}