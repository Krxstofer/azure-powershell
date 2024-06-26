// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Extensions;

    /// <summary>Specifies the storage settings for the virtual machine disks.</summary>
    public partial class StorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IStorageProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IStorageProfileInternal
    {

        /// <summary>Backing field for <see cref="Disk" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk> _disk;

        /// <summary>Gets or sets the list of virtual disks associated with the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk> Disk { get => this._disk; set => this._disk = value; }

        /// <summary>Internal Acessors for ScsiController</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualScsiController> Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IStorageProfileInternal.ScsiController { get => this._scsiController; set { {_scsiController = value;} } }

        /// <summary>Backing field for <see cref="ScsiController" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualScsiController> _scsiController;

        /// <summary>
        /// Gets or sets the list of virtual SCSI controllers associated with the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualScsiController> ScsiController { get => this._scsiController; }

        /// <summary>Creates an new <see cref="StorageProfile" /> instance.</summary>
        public StorageProfile()
        {

        }
    }
    /// Specifies the storage settings for the virtual machine disks.
    public partial interface IStorageProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the list of virtual disks associated with the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the list of virtual disks associated with the virtual machine.",
        SerializedName = @"disks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk> Disk { get; set; }
        /// <summary>
        /// Gets or sets the list of virtual SCSI controllers associated with the virtual machine.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the list of virtual SCSI controllers associated with the virtual machine.",
        SerializedName = @"scsiControllers",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualScsiController) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualScsiController> ScsiController { get;  }

    }
    /// Specifies the storage settings for the virtual machine disks.
    internal partial interface IStorageProfileInternal

    {
        /// <summary>Gets or sets the list of virtual disks associated with the virtual machine.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualDisk> Disk { get; set; }
        /// <summary>
        /// Gets or sets the list of virtual SCSI controllers associated with the virtual machine.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualScsiController> ScsiController { get; set; }

    }
}