// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.PowerShell;

    /// <summary>Properties of the subnet.</summary>
    [System.ComponentModel.TypeConverter(typeof(SubnetPropertiesFormatTypeConverter))]
    public partial class SubnetPropertiesFormat
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.SubnetPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormat" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormat DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SubnetPropertiesFormat(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.SubnetPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormat" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormat DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SubnetPropertiesFormat(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SubnetPropertiesFormat" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SubnetPropertiesFormat" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormat FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.SubnetPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SubnetPropertiesFormat(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RouteTable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTable = (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRouteTable) content.GetValueForProperty("RouteTable",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTable, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.RouteTableTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefix = (string) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("AddressPrefixes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefixes = (System.Collections.Generic.List<string>) content.GetValueForProperty("AddressPrefixes",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefixes, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IPAllocationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPAllocationMethod = (string) content.GetValueForProperty("IPAllocationMethod",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPAllocationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("IPConfigurationReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPConfigurationReference = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatIPConfigurationReferencesItem>) content.GetValueForProperty("IPConfigurationReference",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPConfigurationReference, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatIPConfigurationReferencesItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.SubnetPropertiesFormatIPConfigurationReferencesItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("IPPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IIPPool>) content.GetValueForProperty("IPPool",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IIPPool>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IPPoolTypeConverter.ConvertFrom));
            }
            if (content.Contains("Vlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Vlan = (int?) content.GetValueForProperty("Vlan",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Vlan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RouteTableEtag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableEtag = (string) content.GetValueForProperty("RouteTableEtag",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableEtag, global::System.Convert.ToString);
            }
            if (content.Contains("RouteTableName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableName = (string) content.GetValueForProperty("RouteTableName",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableName, global::System.Convert.ToString);
            }
            if (content.Contains("RouteTableType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableType = (string) content.GetValueForProperty("RouteTableType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableType, global::System.Convert.ToString);
            }
            if (content.Contains("RouteTableProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableProperty = (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRouteTablePropertiesFormat) content.GetValueForProperty("RouteTableProperty",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableProperty, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.RouteTablePropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Route"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Route = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRoute>) content.GetValueForProperty("Route",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Route, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRoute>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.RouteTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.SubnetPropertiesFormat"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SubnetPropertiesFormat(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("RouteTable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTable = (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRouteTable) content.GetValueForProperty("RouteTable",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTable, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.RouteTableTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddressPrefix"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefix = (string) content.GetValueForProperty("AddressPrefix",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefix, global::System.Convert.ToString);
            }
            if (content.Contains("AddressPrefixes"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefixes = (System.Collections.Generic.List<string>) content.GetValueForProperty("AddressPrefixes",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).AddressPrefixes, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IPAllocationMethod"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPAllocationMethod = (string) content.GetValueForProperty("IPAllocationMethod",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPAllocationMethod, global::System.Convert.ToString);
            }
            if (content.Contains("IPConfigurationReference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPConfigurationReference = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatIPConfigurationReferencesItem>) content.GetValueForProperty("IPConfigurationReference",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPConfigurationReference, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatIPConfigurationReferencesItem>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.SubnetPropertiesFormatIPConfigurationReferencesItemTypeConverter.ConvertFrom));
            }
            if (content.Contains("IPPool"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPPool = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IIPPool>) content.GetValueForProperty("IPPool",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).IPPool, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IIPPool>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IPPoolTypeConverter.ConvertFrom));
            }
            if (content.Contains("Vlan"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Vlan = (int?) content.GetValueForProperty("Vlan",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Vlan, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("RouteTableEtag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableEtag = (string) content.GetValueForProperty("RouteTableEtag",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableEtag, global::System.Convert.ToString);
            }
            if (content.Contains("RouteTableName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableName = (string) content.GetValueForProperty("RouteTableName",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableName, global::System.Convert.ToString);
            }
            if (content.Contains("RouteTableType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableType = (string) content.GetValueForProperty("RouteTableType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableType, global::System.Convert.ToString);
            }
            if (content.Contains("RouteTableProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableProperty = (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRouteTablePropertiesFormat) content.GetValueForProperty("RouteTableProperty",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).RouteTableProperty, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.RouteTablePropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Route"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Route = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRoute>) content.GetValueForProperty("Route",((Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnetPropertiesFormatInternal)this).Route, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IRoute>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.RouteTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Properties of the subnet.
    [System.ComponentModel.TypeConverter(typeof(SubnetPropertiesFormatTypeConverter))]
    public partial interface ISubnetPropertiesFormat

    {

    }
}