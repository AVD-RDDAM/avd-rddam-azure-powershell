// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Workspace patch details
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class WorkspacePatchInfo
    {
        /// <summary>
        /// Initializes a new instance of the WorkspacePatchInfo class.
        /// </summary>
        public WorkspacePatchInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspacePatchInfo class.
        /// </summary>

        /// <param name="tags">Resource tags
        /// </param>

        /// <param name="identity">The identity of the workspace
        /// </param>

        /// <param name="purviewConfiguration">Purview Configuration
        /// </param>

        /// <param name="sqlAdministratorLoginPassword">SQL administrator login password
        /// </param>

        /// <param name="managedVirtualNetworkSettings">Managed Virtual Network Settings
        /// </param>

        /// <param name="workspaceRepositoryConfiguration">Git integration settings
        /// </param>

        /// <param name="provisioningState">Resource provisioning state
        /// </param>

        /// <param name="encryption">The encryption details of the workspace
        /// </param>

        /// <param name="publicNetworkAccess">Enable or Disable public network access to workspace
        /// Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;</param>
        public WorkspacePatchInfo(System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), ManagedIdentity identity = default(ManagedIdentity), PurviewConfiguration purviewConfiguration = default(PurviewConfiguration), string sqlAdministratorLoginPassword = default(string), ManagedVirtualNetworkSettings managedVirtualNetworkSettings = default(ManagedVirtualNetworkSettings), WorkspaceRepositoryConfiguration workspaceRepositoryConfiguration = default(WorkspaceRepositoryConfiguration), string provisioningState = default(string), EncryptionDetails encryption = default(EncryptionDetails), string publicNetworkAccess = default(string))

        {
            this.Tags = tags;
            this.Identity = identity;
            this.PurviewConfiguration = purviewConfiguration;
            this.SqlAdministratorLoginPassword = sqlAdministratorLoginPassword;
            this.ManagedVirtualNetworkSettings = managedVirtualNetworkSettings;
            this.WorkspaceRepositoryConfiguration = workspaceRepositoryConfiguration;
            this.ProvisioningState = provisioningState;
            this.Encryption = encryption;
            this.PublicNetworkAccess = publicNetworkAccess;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets or sets the identity of the workspace
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public ManagedIdentity Identity {get; set; }

        /// <summary>
        /// Gets or sets purview Configuration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.purviewConfiguration")]
        public PurviewConfiguration PurviewConfiguration {get; set; }

        /// <summary>
        /// Gets or sets sQL administrator login password
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sqlAdministratorLoginPassword")]
        public string SqlAdministratorLoginPassword {get; set; }

        /// <summary>
        /// Gets or sets managed Virtual Network Settings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.managedVirtualNetworkSettings")]
        public ManagedVirtualNetworkSettings ManagedVirtualNetworkSettings {get; set; }

        /// <summary>
        /// Gets or sets git integration settings
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.workspaceRepositoryConfiguration")]
        public WorkspaceRepositoryConfiguration WorkspaceRepositoryConfiguration {get; set; }

        /// <summary>
        /// Gets resource provisioning state
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the encryption details of the workspace
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionDetails Encryption {get; set; }

        /// <summary>
        /// Gets or sets enable or Disable public network access to workspace Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public string PublicNetworkAccess {get; set; }
    }
}