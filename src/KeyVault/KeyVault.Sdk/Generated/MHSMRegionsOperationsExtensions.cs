// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.KeyVault
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for MhsmRegionsOperations
    /// </summary>
    public static partial class MhsmRegionsOperationsExtensions
    {
        /// <summary>
        /// The List operation gets information about the regions associated with the managed HSM Pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the managed HSM pool.
        /// </param>
        /// <param name='name'>
        /// Name of the managed HSM Pool
        /// </param>
        public static Microsoft.Rest.Azure.IPage<MhsmGeoReplicatedRegion> ListByResource(this IMhsmRegionsOperations operations, string resourceGroupName, string name)
        {
                return ((IMhsmRegionsOperations)operations).ListByResourceAsync(resourceGroupName, name).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The List operation gets information about the regions associated with the managed HSM Pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Name of the resource group that contains the managed HSM pool.
        /// </param>
        /// <param name='name'>
        /// Name of the managed HSM Pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<MhsmGeoReplicatedRegion>> ListByResourceAsync(this IMhsmRegionsOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// The List operation gets information about the regions associated with the managed HSM Pool.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<MhsmGeoReplicatedRegion> ListByResourceNext(this IMhsmRegionsOperations operations, string nextPageLink)
        {
                return ((IMhsmRegionsOperations)operations).ListByResourceNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// The List operation gets information about the regions associated with the managed HSM Pool.
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
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<MhsmGeoReplicatedRegion>> ListByResourceNextAsync(this IMhsmRegionsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
