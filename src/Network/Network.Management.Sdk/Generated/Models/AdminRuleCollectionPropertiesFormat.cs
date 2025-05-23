// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Defines the admin rule collection properties.
    /// </summary>
    public partial class AdminRuleCollectionPropertiesFormat
    {
        /// <summary>
        /// Initializes a new instance of the AdminRuleCollectionPropertiesFormat class.
        /// </summary>
        public AdminRuleCollectionPropertiesFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AdminRuleCollectionPropertiesFormat class.
        /// </summary>

        /// <param name="description">A description of the admin rule collection.
        /// </param>

        /// <param name="appliesToGroups">Groups for configuration
        /// </param>

        /// <param name="provisioningState">The provisioning state of the resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="resourceGuid">Unique identifier for this resource.
        /// </param>
        public AdminRuleCollectionPropertiesFormat(System.Collections.Generic.IList<NetworkManagerSecurityGroupItem> appliesToGroups, string description = default(string), string provisioningState = default(string), string resourceGuid = default(string))

        {
            this.Description = description;
            this.AppliesToGroups = appliesToGroups;
            this.ProvisioningState = provisioningState;
            this.ResourceGuid = resourceGuid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets a description of the admin rule collection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets groups for configuration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "appliesToGroups")]
        public System.Collections.Generic.IList<NetworkManagerSecurityGroupItem> AppliesToGroups {get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets unique identifier for this resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGuid")]
        public string ResourceGuid {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.AppliesToGroups == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "AppliesToGroups");
            }

            if (this.AppliesToGroups != null)
            {
                foreach (var element in this.AppliesToGroups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }


        }
    }
}