// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support
{

    /// <summary>Defines the disk sku name.</summary>
    public partial struct DiskSkuName :
        System.IEquatable<DiskSkuName>
    {
        /// <summary>Premium_LRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName PremiumLrs = @"Premium_LRS";

        /// <summary>PremiumV2_LRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName PremiumV2Lrs = @"PremiumV2_LRS";

        /// <summary>Premium_ZRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName PremiumZrs = @"Premium_ZRS";

        /// <summary>Standard LRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName StandardLrs = @"Standard_LRS";

        /// <summary>StandardSSD_LRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName StandardSsdLrs = @"StandardSSD_LRS";

        /// <summary>StandardSSD_ZRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName StandardSsdZrs = @"StandardSSD_ZRS";

        /// <summary>UltraSSD_LRS Disk SKU.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName UltraSsdLrs = @"UltraSSD_LRS";

        /// <summary>the value for an instance of the <see cref="DiskSkuName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to DiskSkuName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DiskSkuName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new DiskSkuName(global::System.Convert.ToString(value));
        }

        /// <summary>Creates an instance of the <see cref="DiskSkuName"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private DiskSkuName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type DiskSkuName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type DiskSkuName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is DiskSkuName && Equals((DiskSkuName)obj);
        }

        /// <summary>Returns hashCode for enum DiskSkuName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for DiskSkuName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to DiskSkuName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="DiskSkuName" />.</param>

        public static implicit operator DiskSkuName(string value)
        {
            return new DiskSkuName(value);
        }

        /// <summary>Implicit operator to convert DiskSkuName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="DiskSkuName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum DiskSkuName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName e1, Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum DiskSkuName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName e1, Microsoft.Azure.PowerShell.Cmdlets.Workloads.SapVirtualInstance.Support.DiskSkuName e2)
        {
            return e2.Equals(e1);
        }
    }
}