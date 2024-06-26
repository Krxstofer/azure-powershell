// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Support
{

    /// <summary>
    /// The default is 'standard'. See [Azure Load Balancer SKUs](https://docs.microsoft.com/azure/load-balancer/skus) for more
    /// information about the differences between load balancer SKUs.
    /// </summary>
    public partial struct LoadBalancerSku :
        System.IEquatable<LoadBalancerSku>
    {
        /// <summary>Use a basic Load Balancer with limited functionality.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku Basic = @"basic";

        /// <summary>
        /// Use a a standard Load Balancer. This is the recommended Load Balancer SKU. For more information about on working with
        /// the load balancer in the managed cluster, see the [standard Load Balancer](https://docs.microsoft.com/azure/aks/load-balancer-standard)
        /// article.
        /// </summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku Standard = @"standard";

        /// <summary>the value for an instance of the <see cref="LoadBalancerSku" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LoadBalancerSku</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LoadBalancerSku" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LoadBalancerSku(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LoadBalancerSku</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LoadBalancerSku (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LoadBalancerSku && Equals((LoadBalancerSku)obj);
        }

        /// <summary>Returns hashCode for enum LoadBalancerSku</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LoadBalancerSku"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LoadBalancerSku(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LoadBalancerSku</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LoadBalancerSku</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LoadBalancerSku" />.</param>

        public static implicit operator LoadBalancerSku(string value)
        {
            return new LoadBalancerSku(value);
        }

        /// <summary>Implicit operator to convert LoadBalancerSku to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LoadBalancerSku" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LoadBalancerSku</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LoadBalancerSku</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku e1, Microsoft.Azure.PowerShell.Cmdlets.Aks.Support.LoadBalancerSku e2)
        {
            return e2.Equals(e1);
        }
    }
}