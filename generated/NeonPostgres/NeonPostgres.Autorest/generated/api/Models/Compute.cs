// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>The Compute resource type.</summary>
    public partial class Compute :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompute,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ProxyResource();

        /// <summary>Additional attributes for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Attribute; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Attribute = value ?? null /* arrayOf */; }

        /// <summary>Number of allocated CPU cores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public int? CpuCore { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).CpuCore; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).CpuCore = value ?? default(int); }

        /// <summary>Timestamp indicating when the entity was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).CreatedAt; }

        /// <summary>Unique identifier for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string EntityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).EntityId; }

        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string EntityName { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).EntityName; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).EntityName = value ?? null; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Memory allocated in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public int? Memory { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Memory; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Memory = value ?? default(int); }

        /// <summary>Internal Acessors for CreatedAt</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).CreatedAt = value ?? null; }

        /// <summary>Internal Acessors for EntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeInternal.EntityId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).EntityId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).EntityId = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeProperties Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ComputeProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Id = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Name = value ?? null; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Type = value ?? null; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ComputeProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).ProvisioningState; }

        /// <summary>Region where the compute instance is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string Region { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Region; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Region = value ?? null; }

        /// <summary>Current status of the compute instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inlined)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputePropertiesInternal)Property).Status = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="Compute" /> instance.</summary>
        public Compute()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// The Compute resource type.
    public partial interface ICompute :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IProxyResource
    {
        /// <summary>Additional attributes for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional attributes for the entity",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get; set; }
        /// <summary>Number of allocated CPU cores</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of allocated CPU cores",
        SerializedName = @"cpuCores",
        PossibleTypes = new [] { typeof(int) })]
        int? CpuCore { get; set; }
        /// <summary>Timestamp indicating when the entity was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Timestamp indicating when the entity was created",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedAt { get;  }
        /// <summary>Unique identifier for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique identifier for the entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        string EntityId { get;  }
        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the resource",
        SerializedName = @"entityName",
        PossibleTypes = new [] { typeof(string) })]
        string EntityName { get; set; }
        /// <summary>Memory allocated in GB</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Memory allocated in GB",
        SerializedName = @"memory",
        PossibleTypes = new [] { typeof(int) })]
        int? Memory { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Region where the compute instance is located</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Region where the compute instance is located",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }
        /// <summary>Current status of the compute instance</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Current status of the compute instance",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// The Compute resource type.
    internal partial interface IComputeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IProxyResourceInternal
    {
        /// <summary>Additional attributes for the entity</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get; set; }
        /// <summary>Number of allocated CPU cores</summary>
        int? CpuCore { get; set; }
        /// <summary>Timestamp indicating when the entity was created</summary>
        string CreatedAt { get; set; }
        /// <summary>Unique identifier for the entity</summary>
        string EntityId { get; set; }
        /// <summary>Name of the resource</summary>
        string EntityName { get; set; }
        /// <summary>Memory allocated in GB</summary>
        int? Memory { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IComputeProperties Property { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Region where the compute instance is located</summary>
        string Region { get; set; }
        /// <summary>Current status of the compute instance</summary>
        string Status { get; set; }

    }
}