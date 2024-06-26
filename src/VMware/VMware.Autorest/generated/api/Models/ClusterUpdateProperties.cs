// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>The properties of a cluster that may be updated</summary>
    public partial class ClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IClusterUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IClusterUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ClusterSize" /> property.</summary>
        private int? _clusterSize;

        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public int? ClusterSize { get => this._clusterSize; set => this._clusterSize = value; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private System.Collections.Generic.List<string> _host;

        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Host { get => this._host; set => this._host = value; }

        /// <summary>Creates an new <see cref="ClusterUpdateProperties" /> instance.</summary>
        public ClusterUpdateProperties()
        {

        }
    }
    /// The properties of a cluster that may be updated
    public partial interface IClusterUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable
    {
        /// <summary>The cluster size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The cluster size",
        SerializedName = @"clusterSize",
        PossibleTypes = new [] { typeof(int) })]
        int? ClusterSize { get; set; }
        /// <summary>The hosts</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The hosts",
        SerializedName = @"hosts",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Host { get; set; }

    }
    /// The properties of a cluster that may be updated
    internal partial interface IClusterUpdatePropertiesInternal

    {
        /// <summary>The cluster size</summary>
        int? ClusterSize { get; set; }
        /// <summary>The hosts</summary>
        System.Collections.Generic.List<string> Host { get; set; }

    }
}