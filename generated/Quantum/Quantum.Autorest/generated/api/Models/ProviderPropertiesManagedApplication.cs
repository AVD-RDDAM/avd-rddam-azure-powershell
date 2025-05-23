// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Extensions;

    /// <summary>Provider's Managed-Application info</summary>
    public partial class ProviderPropertiesManagedApplication :
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.IProviderPropertiesManagedApplication,
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.IProviderPropertiesManagedApplicationInternal
    {

        /// <summary>Internal Acessors for OfferId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.IProviderPropertiesManagedApplicationInternal.OfferId { get => this._offerId; set { {_offerId = value;} } }

        /// <summary>Internal Acessors for PublisherId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Quantum.Models.IProviderPropertiesManagedApplicationInternal.PublisherId { get => this._publisherId; set { {_publisherId = value;} } }

        /// <summary>Backing field for <see cref="OfferId" /> property.</summary>
        private string _offerId;

        /// <summary>Provider's offer id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quantum.PropertyOrigin.Owned)]
        public string OfferId { get => this._offerId; }

        /// <summary>Backing field for <see cref="PublisherId" /> property.</summary>
        private string _publisherId;

        /// <summary>Provider's publisher id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Origin(Microsoft.Azure.PowerShell.Cmdlets.Quantum.PropertyOrigin.Owned)]
        public string PublisherId { get => this._publisherId; }

        /// <summary>Creates an new <see cref="ProviderPropertiesManagedApplication" /> instance.</summary>
        public ProviderPropertiesManagedApplication()
        {

        }
    }
    /// Provider's Managed-Application info
    public partial interface IProviderPropertiesManagedApplication :
        Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.IJsonSerializable
    {
        /// <summary>Provider's offer id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provider's offer id.",
        SerializedName = @"offerId",
        PossibleTypes = new [] { typeof(string) })]
        string OfferId { get;  }
        /// <summary>Provider's publisher id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Quantum.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provider's publisher id.",
        SerializedName = @"publisherId",
        PossibleTypes = new [] { typeof(string) })]
        string PublisherId { get;  }

    }
    /// Provider's Managed-Application info
    internal partial interface IProviderPropertiesManagedApplicationInternal

    {
        /// <summary>Provider's offer id.</summary>
        string OfferId { get; set; }
        /// <summary>Provider's publisher id.</summary>
        string PublisherId { get; set; }

    }
}