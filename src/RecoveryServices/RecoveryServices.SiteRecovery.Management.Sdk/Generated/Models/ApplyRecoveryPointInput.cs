// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Input to apply recovery point.
    /// </summary>
    public partial class ApplyRecoveryPointInput
    {
        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInput class.
        /// </summary>
        public ApplyRecoveryPointInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInput class.
        /// </summary>

        /// <param name="properties">The input properties to apply recovery point.
        /// </param>
        public ApplyRecoveryPointInput(ApplyRecoveryPointInputProperties properties)

        {
            this.Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the input properties to apply recovery point.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties")]
        public ApplyRecoveryPointInputProperties Properties {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Properties == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Properties");
            }
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}