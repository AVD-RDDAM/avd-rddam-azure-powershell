// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support
{

    /// <summary>
    /// The indicator of whether the platform default endpoints are allowed for the egress traffic.
    /// </summary>
    public partial struct CloudServicesNetworkEnableDefaultEgressEndpoints :
        System.IEquatable<CloudServicesNetworkEnableDefaultEgressEndpoints>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints False = @"False";

        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints True = @"True";

        /// <summary>
        /// the value for an instance of the <see cref="CloudServicesNetworkEnableDefaultEgressEndpoints" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>
        /// Creates an instance of the <see cref="CloudServicesNetworkEnableDefaultEgressEndpoints"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CloudServicesNetworkEnableDefaultEgressEndpoints(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>
        /// Conversion from arbitrary object to CloudServicesNetworkEnableDefaultEgressEndpoints
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="CloudServicesNetworkEnableDefaultEgressEndpoints"
        /// />.</param>
        internal static object CreateFrom(object value)
        {
            return new CloudServicesNetworkEnableDefaultEgressEndpoints(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type CloudServicesNetworkEnableDefaultEgressEndpoints</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>
        /// Compares values of enum type CloudServicesNetworkEnableDefaultEgressEndpoints (override for Object)
        /// </summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CloudServicesNetworkEnableDefaultEgressEndpoints && Equals((CloudServicesNetworkEnableDefaultEgressEndpoints)obj);
        }

        /// <summary>Returns hashCode for enum CloudServicesNetworkEnableDefaultEgressEndpoints</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Returns string representation for CloudServicesNetworkEnableDefaultEgressEndpoints
        /// </summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>
        /// Implicit operator to convert string to CloudServicesNetworkEnableDefaultEgressEndpoints
        /// </summary>
        /// <param name="value">the value to convert to an instance of <see cref="CloudServicesNetworkEnableDefaultEgressEndpoints"
        /// />.</param>

        public static implicit operator CloudServicesNetworkEnableDefaultEgressEndpoints(string value)
        {
            return new CloudServicesNetworkEnableDefaultEgressEndpoints(value);
        }

        /// <summary>
        /// Implicit operator to convert CloudServicesNetworkEnableDefaultEgressEndpoints to string
        /// </summary>
        /// <param name="e">the value to convert to an instance of <see cref="CloudServicesNetworkEnableDefaultEgressEndpoints" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints e)
        {
            return e._value;
        }

        /// <summary>
        /// Overriding != operator for enum CloudServicesNetworkEnableDefaultEgressEndpoints
        /// </summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints e1, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overriding == operator for enum CloudServicesNetworkEnableDefaultEgressEndpoints
        /// </summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints e1, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.CloudServicesNetworkEnableDefaultEgressEndpoints e2)
        {
            return e2.Equals(e1);
        }
    }
}