// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Extensions;

    /// <summary>Data POST-ed to the nameAvailability action</summary>
    public partial class NameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.INameAvailabilityParameters,
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Models.Api20220801Preview.INameAvailabilityParametersInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The resource name to validate. e.g."my-resource-name"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// The resource type. Can be "Microsoft.SignalRService/SignalR" or "Microsoft.SignalRService/webPubSub"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Origin(Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="NameAvailabilityParameters" /> instance.</summary>
        public NameAvailabilityParameters()
        {

        }
    }
    /// Data POST-ed to the nameAvailability action
    public partial interface INameAvailabilityParameters :
        Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.IJsonSerializable
    {
        /// <summary>The resource name to validate. e.g."my-resource-name"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource name to validate. e.g.""my-resource-name""",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The resource type. Can be "Microsoft.SignalRService/SignalR" or "Microsoft.SignalRService/webPubSub"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.WebPubSub.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource type. Can be ""Microsoft.SignalRService/SignalR"" or ""Microsoft.SignalRService/webPubSub""",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Data POST-ed to the nameAvailability action
    internal partial interface INameAvailabilityParametersInternal

    {
        /// <summary>The resource name to validate. e.g."my-resource-name"</summary>
        string Name { get; set; }
        /// <summary>
        /// The resource type. Can be "Microsoft.SignalRService/SignalR" or "Microsoft.SignalRService/webPubSub"
        /// </summary>
        string Type { get; set; }

    }
}