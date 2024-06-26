// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>
    /// HardwareProfile - Specifies the hardware settings for the virtual machine instance.
    /// </summary>
    public partial class VirtualMachineInstancePropertiesHardwareProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfile,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileInternal
    {

        /// <summary>Backing field for <see cref="DynamicMemoryConfig" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig _dynamicMemoryConfig;

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig DynamicMemoryConfig { get => (this._dynamicMemoryConfig = this._dynamicMemoryConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig()); set => this._dynamicMemoryConfig = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Inlined)]
        public long? DynamicMemoryConfigMaximumMemoryMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfigInternal)DynamicMemoryConfig).MaximumMemoryMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfigInternal)DynamicMemoryConfig).MaximumMemoryMb = value ?? default(long); }

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Inlined)]
        public long? DynamicMemoryConfigMinimumMemoryMb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfigInternal)DynamicMemoryConfig).MinimumMemoryMb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfigInternal)DynamicMemoryConfig).MinimumMemoryMb = value ?? default(long); }

        /// <summary>
        /// Defines the amount of extra memory that should be reserved for a virtual machine instance at runtime, as a percentage
        /// of the total memory that the virtual machine instance is thought to need. This only applies to virtual systems with dynamic
        /// memory enabled. This property can be in the range of 5 to 2000.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Inlined)]
        public int? DynamicMemoryConfigTargetMemoryBuffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfigInternal)DynamicMemoryConfig).TargetMemoryBuffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfigInternal)DynamicMemoryConfig).TargetMemoryBuffer = value ?? default(int); }

        /// <summary>Backing field for <see cref="MemoryMb" /> property.</summary>
        private long? _memoryMb;

        /// <summary>RAM in MB for the virtual machine instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public long? MemoryMb { get => this._memoryMb; set => this._memoryMb = value; }

        /// <summary>Internal Acessors for DynamicMemoryConfig</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileInternal.DynamicMemoryConfig { get => (this._dynamicMemoryConfig = this._dynamicMemoryConfig ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.VirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig()); set { {_dynamicMemoryConfig = value;} } }

        /// <summary>Backing field for <see cref="Processor" /> property.</summary>
        private int? _processor;

        /// <summary>number of processors for the virtual machine instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public int? Processor { get => this._processor; set => this._processor = value; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private string _vMSize;

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>
        /// Creates an new <see cref="VirtualMachineInstancePropertiesHardwareProfile" /> instance.
        /// </summary>
        public VirtualMachineInstancePropertiesHardwareProfile()
        {

        }
    }
    /// HardwareProfile - Specifies the hardware settings for the virtual machine instance.
    public partial interface IVirtualMachineInstancePropertiesHardwareProfile :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"maximumMemoryMB",
        PossibleTypes = new [] { typeof(long) })]
        long? DynamicMemoryConfigMaximumMemoryMb { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"minimumMemoryMB",
        PossibleTypes = new [] { typeof(long) })]
        long? DynamicMemoryConfigMinimumMemoryMb { get; set; }
        /// <summary>
        /// Defines the amount of extra memory that should be reserved for a virtual machine instance at runtime, as a percentage
        /// of the total memory that the virtual machine instance is thought to need. This only applies to virtual systems with dynamic
        /// memory enabled. This property can be in the range of 5 to 2000.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the amount of extra memory that should be reserved for a virtual machine instance at runtime, as a percentage of the total memory that the virtual machine instance is thought to need. This only applies to virtual systems with dynamic memory enabled. This property can be in the range of 5 to 2000.",
        SerializedName = @"targetMemoryBuffer",
        PossibleTypes = new [] { typeof(int) })]
        int? DynamicMemoryConfigTargetMemoryBuffer { get; set; }
        /// <summary>RAM in MB for the virtual machine instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"RAM in MB for the virtual machine instance",
        SerializedName = @"memoryMB",
        PossibleTypes = new [] { typeof(long) })]
        long? MemoryMb { get; set; }
        /// <summary>number of processors for the virtual machine instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"number of processors for the virtual machine instance",
        SerializedName = @"processors",
        PossibleTypes = new [] { typeof(int) })]
        int? Processor { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PSArgumentCompleterAttribute("Default", "Standard_A2_v2", "Standard_A4_v2", "Standard_D2s_v3", "Standard_D4s_v3", "Standard_D8s_v3", "Standard_D16s_v3", "Standard_D32s_v3", "Standard_DS2_v2", "Standard_DS3_v2", "Standard_DS4_v2", "Standard_DS5_v2", "Standard_DS13_v2", "Standard_K8S_v1", "Standard_K8S2_v1", "Standard_K8S3_v1", "Standard_K8S4_v1", "Standard_NK6", "Standard_NK12", "Standard_NV6", "Standard_NV12", "Standard_K8S5_v1", "Custom")]
        string VMSize { get; set; }

    }
    /// HardwareProfile - Specifies the hardware settings for the virtual machine instance.
    internal partial interface IVirtualMachineInstancePropertiesHardwareProfileInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IVirtualMachineInstancePropertiesHardwareProfileDynamicMemoryConfig DynamicMemoryConfig { get; set; }

        long? DynamicMemoryConfigMaximumMemoryMb { get; set; }

        long? DynamicMemoryConfigMinimumMemoryMb { get; set; }
        /// <summary>
        /// Defines the amount of extra memory that should be reserved for a virtual machine instance at runtime, as a percentage
        /// of the total memory that the virtual machine instance is thought to need. This only applies to virtual systems with dynamic
        /// memory enabled. This property can be in the range of 5 to 2000.
        /// </summary>
        int? DynamicMemoryConfigTargetMemoryBuffer { get; set; }
        /// <summary>RAM in MB for the virtual machine instance</summary>
        long? MemoryMb { get; set; }
        /// <summary>number of processors for the virtual machine instance</summary>
        int? Processor { get; set; }

        [global::Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PSArgumentCompleterAttribute("Default", "Standard_A2_v2", "Standard_A4_v2", "Standard_D2s_v3", "Standard_D4s_v3", "Standard_D8s_v3", "Standard_D16s_v3", "Standard_D32s_v3", "Standard_DS2_v2", "Standard_DS3_v2", "Standard_DS4_v2", "Standard_DS5_v2", "Standard_DS13_v2", "Standard_K8S_v1", "Standard_K8S2_v1", "Standard_K8S3_v1", "Standard_K8S4_v1", "Standard_NK6", "Standard_NK12", "Standard_NV6", "Standard_NV12", "Standard_K8S5_v1", "Custom")]
        string VMSize { get; set; }

    }
}