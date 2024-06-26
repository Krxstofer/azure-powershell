// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The tags that will be assigned to the key vault.</summary>
    public partial class VaultPatchParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IVaultPatchParametersTags,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IVaultPatchParametersTagsInternal
    {

        /// <summary>Creates an new <see cref="VaultPatchParametersTags" /> instance.</summary>
        public VaultPatchParametersTags()
        {

        }
    }
    /// The tags that will be assigned to the key vault.
    public partial interface IVaultPatchParametersTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IAssociativeArray<string>
    {

    }
    /// The tags that will be assigned to the key vault.
    internal partial interface IVaultPatchParametersTagsInternal

    {

    }
}