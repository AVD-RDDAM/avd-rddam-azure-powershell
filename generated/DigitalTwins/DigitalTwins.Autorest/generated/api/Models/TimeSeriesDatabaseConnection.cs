// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Extensions;

    /// <summary>Describes a time series database connection resource.</summary>
    public partial class TimeSeriesDatabaseConnection :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnection,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResource __externalResource = new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ExternalResource();

        /// <summary>The type of time series connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 1)]
        public string ConnectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionPropertiesInternal)Property).ConnectionType; }

        /// <summary>The resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Type = value ?? null; }

        /// <summary>Internal Acessors for ConnectionType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionInternal.ConnectionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionPropertiesInternal)Property).ConnectionType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionPropertiesInternal)Property).ConnectionType = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionProperties Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.TimeSeriesDatabaseConnectionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Extension resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionProperties _property;

        /// <summary>Properties of a specific time series database connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.TimeSeriesDatabaseConnectionProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 2)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.FormatTable(Index = 3)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).SystemDataLastModifiedByType; }

        /// <summary>The resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Origin(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal)__externalResource).Type; }

        /// <summary>Creates an new <see cref="TimeSeriesDatabaseConnection" /> instance.</summary>
        public TimeSeriesDatabaseConnection()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__externalResource), __externalResource);
            await eventListener.AssertObjectIsValid(nameof(__externalResource), __externalResource);
        }
    }
    /// Describes a time series database connection resource.
    public partial interface ITimeSeriesDatabaseConnection :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResource
    {
        /// <summary>The type of time series connection resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of time series connection resource.",
        SerializedName = @"connectionType",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionType { get;  }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PSArgumentCompleterAttribute("Provisioning", "Deleting", "Updating", "Succeeded", "Failed", "Canceled", "Deleted", "Warning", "Suspending", "Restoring", "Moving", "Disabled")]
        string ProvisioningState { get;  }

    }
    /// Describes a time series database connection resource.
    internal partial interface ITimeSeriesDatabaseConnectionInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IExternalResourceInternal
    {
        /// <summary>The type of time series connection resource.</summary>
        string ConnectionType { get; set; }
        /// <summary>Properties of a specific time series database connection.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.ITimeSeriesDatabaseConnectionProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.PSArgumentCompleterAttribute("Provisioning", "Deleting", "Updating", "Succeeded", "Failed", "Canceled", "Deleted", "Warning", "Suspending", "Restoring", "Moving", "Disabled")]
        string ProvisioningState { get; set; }

    }
}