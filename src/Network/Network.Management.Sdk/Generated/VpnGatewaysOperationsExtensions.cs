// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VpnGatewaysOperations.
    /// </summary>
    public static partial class VpnGatewaysOperationsExtensions
    {
            /// <summary>
            /// Retrieves the details of a virtual wan vpn gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            public static VpnGateway Get(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName)
            {
                return operations.GetAsync(resourceGroupName, gatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the details of a virtual wan vpn gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> GetAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a virtual wan vpn gateway if it doesn't exist else updates the
            /// existing gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='vpnGatewayParameters'>
            /// Parameters supplied to create or Update a virtual wan vpn gateway.
            /// </param>
            public static VpnGateway CreateOrUpdate(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, VpnGateway vpnGatewayParameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, gatewayName, vpnGatewayParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a virtual wan vpn gateway if it doesn't exist else updates the
            /// existing gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='vpnGatewayParameters'>
            /// Parameters supplied to create or Update a virtual wan vpn gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> CreateOrUpdateAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, VpnGateway vpnGatewayParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, gatewayName, vpnGatewayParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates virtual wan vpn gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static VpnGateway UpdateTags(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.UpdateTagsAsync(resourceGroupName, gatewayName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates virtual wan vpn gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> UpdateTagsAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, gatewayName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a virtual wan vpn gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            public static void Delete(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName)
            {
                operations.DeleteAsync(resourceGroupName, gatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a virtual wan vpn gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resets the primary of the vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='ipConfigurationId'>
            /// VpnGateway ipConfigurationId to specify the gateway instance.
            /// </param>
            public static VpnGateway Reset(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string ipConfigurationId = default(string))
            {
                return operations.ResetAsync(resourceGroupName, gatewayName, ipConfigurationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the primary of the vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='ipConfigurationId'>
            /// VpnGateway ipConfigurationId to specify the gateway instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> ResetAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string ipConfigurationId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ResetWithHttpMessagesAsync(resourceGroupName, gatewayName, ipConfigurationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='filterData'>
            /// Start Packet capture parameters on vpn gateway.
            /// </param>
            public static string StartPacketCapture(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string filterData = default(string))
            {
                return operations.StartPacketCaptureAsync(resourceGroupName, gatewayName, filterData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='filterData'>
            /// Start Packet capture parameters on vpn gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> StartPacketCaptureAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string filterData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StartPacketCaptureWithHttpMessagesAsync(resourceGroupName, gatewayName, filterData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Stops packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='sasUrl'>
            /// SAS url for packet capture on vpn gateway.
            /// </param>
            public static string StopPacketCapture(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string sasUrl = default(string))
            {
                return operations.StopPacketCaptureAsync(resourceGroupName, gatewayName, sasUrl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='sasUrl'>
            /// SAS url for packet capture on vpn gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> StopPacketCaptureAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string sasUrl = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StopPacketCaptureWithHttpMessagesAsync(resourceGroupName, gatewayName, sasUrl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VpnGateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            public static IPage<VpnGateway> ListByResourceGroup(this IVpnGatewaysOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VpnGateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnGateway>> ListByResourceGroupAsync(this IVpnGatewaysOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VpnGateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<VpnGateway> List(this IVpnGatewaysOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VpnGateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnGateway>> ListAsync(this IVpnGatewaysOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a virtual wan vpn gateway if it doesn't exist else updates the
            /// existing gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='vpnGatewayParameters'>
            /// Parameters supplied to create or Update a virtual wan vpn gateway.
            /// </param>
            public static VpnGateway BeginCreateOrUpdate(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, VpnGateway vpnGatewayParameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, gatewayName, vpnGatewayParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a virtual wan vpn gateway if it doesn't exist else updates the
            /// existing gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='vpnGatewayParameters'>
            /// Parameters supplied to create or Update a virtual wan vpn gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> BeginCreateOrUpdateAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, VpnGateway vpnGatewayParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, gatewayName, vpnGatewayParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates virtual wan vpn gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            public static VpnGateway BeginUpdateTags(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, IDictionary<string, string> tags = default(IDictionary<string, string>))
            {
                return operations.BeginUpdateTagsAsync(resourceGroupName, gatewayName, tags).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates virtual wan vpn gateway tags.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='tags'>
            /// Resource tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> BeginUpdateTagsAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, IDictionary<string, string> tags = default(IDictionary<string, string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateTagsWithHttpMessagesAsync(resourceGroupName, gatewayName, tags, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a virtual wan vpn gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            public static void BeginDelete(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName)
            {
                operations.BeginDeleteAsync(resourceGroupName, gatewayName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a virtual wan vpn gateway.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, gatewayName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resets the primary of the vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='ipConfigurationId'>
            /// VpnGateway ipConfigurationId to specify the gateway instance.
            /// </param>
            public static VpnGateway BeginReset(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string ipConfigurationId = default(string))
            {
                return operations.BeginResetAsync(resourceGroupName, gatewayName, ipConfigurationId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resets the primary of the vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='ipConfigurationId'>
            /// VpnGateway ipConfigurationId to specify the gateway instance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VpnGateway> BeginResetAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string ipConfigurationId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginResetWithHttpMessagesAsync(resourceGroupName, gatewayName, ipConfigurationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='filterData'>
            /// Start Packet capture parameters on vpn gateway.
            /// </param>
            public static string BeginStartPacketCapture(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string filterData = default(string))
            {
                return operations.BeginStartPacketCaptureAsync(resourceGroupName, gatewayName, filterData).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='filterData'>
            /// Start Packet capture parameters on vpn gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> BeginStartPacketCaptureAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string filterData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginStartPacketCaptureWithHttpMessagesAsync(resourceGroupName, gatewayName, filterData, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Stops packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='sasUrl'>
            /// SAS url for packet capture on vpn gateway.
            /// </param>
            public static string BeginStopPacketCapture(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string sasUrl = default(string))
            {
                return operations.BeginStopPacketCaptureAsync(resourceGroupName, gatewayName, sasUrl).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops packet capture on vpn gateway in the specified resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of the VpnGateway.
            /// </param>
            /// <param name='gatewayName'>
            /// The name of the gateway.
            /// </param>
            /// <param name='sasUrl'>
            /// SAS url for packet capture on vpn gateway.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> BeginStopPacketCaptureAsync(this IVpnGatewaysOperations operations, string resourceGroupName, string gatewayName, string sasUrl = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginStopPacketCaptureWithHttpMessagesAsync(resourceGroupName, gatewayName, sasUrl, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VpnGateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VpnGateway> ListByResourceGroupNext(this IVpnGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VpnGateways in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnGateway>> ListByResourceGroupNextAsync(this IVpnGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the VpnGateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VpnGateway> ListNext(this IVpnGatewaysOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the VpnGateways in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VpnGateway>> ListNextAsync(this IVpnGatewaysOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
