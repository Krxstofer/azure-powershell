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
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ExpressRouteLink
    /// </summary>
    /// <remarks>
    /// ExpressRouteLink child resource definition.
    /// </remarks>
    [Rest.Serialization.JsonTransformation]
    public partial class ExpressRouteLink : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ExpressRouteLink class.
        /// </summary>
        public ExpressRouteLink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExpressRouteLink class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="routerName">Name of Azure router associated with
        /// physical port.</param>
        /// <param name="interfaceName">Name of Azure router interface.</param>
        /// <param name="patchPanelId">Mapping between physical port to patch
        /// panel port.</param>
        /// <param name="rackId">Mapping of physical patch panel to
        /// rack.</param>
        /// <param name="coloLocation">Cololocation for ExpressRoute Hybrid
        /// Direct.</param>
        /// <param name="connectorType">Physical fiber port type. Possible
        /// values include: 'LC', 'SC'</param>
        /// <param name="adminState">Administrative state of the physical port.
        /// Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// express route link resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="macSecConfig">MacSec configuration.</param>
        /// <param name="name">Name of child port resource that is unique among
        /// child port resources of the parent.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public ExpressRouteLink(string id = default(string), string routerName = default(string), string interfaceName = default(string), string patchPanelId = default(string), string rackId = default(string), string coloLocation = default(string), string connectorType = default(string), string adminState = default(string), string provisioningState = default(string), ExpressRouteLinkMacSecConfig macSecConfig = default(ExpressRouteLinkMacSecConfig), string name = default(string), string etag = default(string))
            : base(id)
        {
            RouterName = routerName;
            InterfaceName = interfaceName;
            PatchPanelId = patchPanelId;
            RackId = rackId;
            ColoLocation = coloLocation;
            ConnectorType = connectorType;
            AdminState = adminState;
            ProvisioningState = provisioningState;
            MacSecConfig = macSecConfig;
            Name = name;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of Azure router associated with physical port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routerName")]
        public string RouterName { get; private set; }

        /// <summary>
        /// Gets name of Azure router interface.
        /// </summary>
        [JsonProperty(PropertyName = "properties.interfaceName")]
        public string InterfaceName { get; private set; }

        /// <summary>
        /// Gets mapping between physical port to patch panel port.
        /// </summary>
        [JsonProperty(PropertyName = "properties.patchPanelId")]
        public string PatchPanelId { get; private set; }

        /// <summary>
        /// Gets mapping of physical patch panel to rack.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rackId")]
        public string RackId { get; private set; }

        /// <summary>
        /// Gets cololocation for ExpressRoute Hybrid Direct.
        /// </summary>
        [JsonProperty(PropertyName = "properties.coloLocation")]
        public string ColoLocation { get; private set; }

        /// <summary>
        /// Gets physical fiber port type. Possible values include: 'LC', 'SC'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorType")]
        public string ConnectorType { get; private set; }

        /// <summary>
        /// Gets or sets administrative state of the physical port. Possible
        /// values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminState")]
        public string AdminState { get; set; }

        /// <summary>
        /// Gets the provisioning state of the express route link resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets macSec configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.macSecConfig")]
        public ExpressRouteLinkMacSecConfig MacSecConfig { get; set; }

        /// <summary>
        /// Gets or sets name of child port resource that is unique among child
        /// port resources of the parent.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
