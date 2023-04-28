// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines contents of a web application firewall global configuration.
    /// </summary>
    public partial class PolicySettings
    {
        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        public PolicySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        /// <param name="state">The state of the policy. Possible values
        /// include: 'Disabled', 'Enabled'</param>
        /// <param name="mode">The mode of the policy. Possible values include:
        /// 'Prevention', 'Detection'</param>
        /// <param name="requestBodyCheck">Whether to allow WAF to check
        /// request Body.</param>
        /// <param name="requestBodyInspectLimitInKB">Max inspection limit in
        /// KB for request body inspection for WAF.</param>
        /// <param name="requestBodyEnforcement">Whether allow WAF to enforce
        /// request body limits.</param>
        /// <param name="maxRequestBodySizeInKb">Maximum request body size in
        /// Kb for WAF.</param>
        /// <param name="fileUploadEnforcement">Whether allow WAF to enforce
        /// file upload limits.</param>
        /// <param name="fileUploadLimitInMb">Maximum file upload size in Mb
        /// for WAF.</param>
        /// <param name="customBlockResponseStatusCode">If the action type is
        /// block, customer can override the response status code.</param>
        /// <param name="customBlockResponseBody">If the action type is block,
        /// customer can override the response body. The body must be specified
        /// in base64 encoding.</param>
        /// <param name="logScrubbing">To scrub sensitive log fields</param>
        public PolicySettings(string state = default(string), string mode = default(string), bool? requestBodyCheck = default(bool?), int? requestBodyInspectLimitInKB = default(int?), bool? requestBodyEnforcement = default(bool?), int? maxRequestBodySizeInKb = default(int?), bool? fileUploadEnforcement = default(bool?), int? fileUploadLimitInMb = default(int?), int? customBlockResponseStatusCode = default(int?), string customBlockResponseBody = default(string), PolicySettingsLogScrubbing logScrubbing = default(PolicySettingsLogScrubbing))
        {
            State = state;
            Mode = mode;
            RequestBodyCheck = requestBodyCheck;
            RequestBodyInspectLimitInKB = requestBodyInspectLimitInKB;
            RequestBodyEnforcement = requestBodyEnforcement;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadEnforcement = fileUploadEnforcement;
            FileUploadLimitInMb = fileUploadLimitInMb;
            CustomBlockResponseStatusCode = customBlockResponseStatusCode;
            CustomBlockResponseBody = customBlockResponseBody;
            LogScrubbing = logScrubbing;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the policy. Possible values include:
        /// 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the mode of the policy. Possible values include:
        /// 'Prevention', 'Detection'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets whether to allow WAF to check request Body.
        /// </summary>
        [JsonProperty(PropertyName = "requestBodyCheck")]
        public bool? RequestBodyCheck { get; set; }

        /// <summary>
        /// Gets or sets max inspection limit in KB for request body inspection
        /// for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "requestBodyInspectLimitInKB")]
        public int? RequestBodyInspectLimitInKB { get; set; }

        /// <summary>
        /// Gets or sets whether allow WAF to enforce request body limits.
        /// </summary>
        [JsonProperty(PropertyName = "requestBodyEnforcement")]
        public bool? RequestBodyEnforcement { get; set; }

        /// <summary>
        /// Gets or sets maximum request body size in Kb for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "maxRequestBodySizeInKb")]
        public int? MaxRequestBodySizeInKb { get; set; }

        /// <summary>
        /// Gets or sets whether allow WAF to enforce file upload limits.
        /// </summary>
        [JsonProperty(PropertyName = "fileUploadEnforcement")]
        public bool? FileUploadEnforcement { get; set; }

        /// <summary>
        /// Gets or sets maximum file upload size in Mb for WAF.
        /// </summary>
        [JsonProperty(PropertyName = "fileUploadLimitInMb")]
        public int? FileUploadLimitInMb { get; set; }

        /// <summary>
        /// Gets or sets if the action type is block, customer can override the
        /// response status code.
        /// </summary>
        [JsonProperty(PropertyName = "customBlockResponseStatusCode")]
        public int? CustomBlockResponseStatusCode { get; set; }

        /// <summary>
        /// Gets or sets if the action type is block, customer can override the
        /// response body. The body must be specified in base64 encoding.
        /// </summary>
        [JsonProperty(PropertyName = "customBlockResponseBody")]
        public string CustomBlockResponseBody { get; set; }

        /// <summary>
        /// Gets or sets to scrub sensitive log fields
        /// </summary>
        [JsonProperty(PropertyName = "logScrubbing")]
        public PolicySettingsLogScrubbing LogScrubbing { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MaxRequestBodySizeInKb != null)
            {
                if (MaxRequestBodySizeInKb < 8)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxRequestBodySizeInKb", 8);
                }
            }
            if (FileUploadLimitInMb != null)
            {
                if (FileUploadLimitInMb < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "FileUploadLimitInMb", 0);
                }
            }
            if (CustomBlockResponseStatusCode != null)
            {
                if (CustomBlockResponseStatusCode < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "CustomBlockResponseStatusCode", 0);
                }
            }
            if (CustomBlockResponseBody != null)
            {
                if (CustomBlockResponseBody.Length > 32768)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "CustomBlockResponseBody", 32768);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(CustomBlockResponseBody, "^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4})$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "CustomBlockResponseBody", "^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{4})$");
                }
            }
        }
    }
}
