// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of a routing rule that your IoT hub uses to route messages
    /// to endpoints.
    /// </summary>
    public partial class RouteProperties
    {
        /// <summary>
        /// Initializes a new instance of the RouteProperties class.
        /// </summary>
        public RouteProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteProperties class.
        /// </summary>

        /// <param name="name">The name of the route. The name can only include alphanumeric characters,
        /// periods, underscores, hyphens, has a maximum length of 64 characters, and
        /// must be unique.
        /// </param>

        /// <param name="source">The source that the routing rule is to be applied to, such as
        /// DeviceMessages.
        /// Possible values include: &#39;Invalid&#39;, &#39;DeviceMessages&#39;, &#39;TwinChangeEvents&#39;,
        /// &#39;DeviceLifecycleEvents&#39;, &#39;DeviceJobLifecycleEvents&#39;,
        /// &#39;DeviceConnectionStateEvents&#39;</param>

        /// <param name="condition">The condition that is evaluated to apply the routing rule. If no condition
        /// is provided, it evaluates to true by default. For grammar, see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
        /// </param>

        /// <param name="endpointNames">The list of endpoints to which messages that satisfy the condition are
        /// routed. Currently only one endpoint is allowed.
        /// </param>

        /// <param name="isEnabled">Used to specify whether a route is enabled.
        /// </param>
        public RouteProperties(string name, string source, System.Collections.Generic.IList<string> endpointNames, bool isEnabled, string condition = default(string))

        {
            this.Name = name;
            this.Source = source;
            this.Condition = condition;
            this.EndpointNames = endpointNames;
            this.IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the route. The name can only include alphanumeric
        /// characters, periods, underscores, hyphens, has a maximum length of 64
        /// characters, and must be unique.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the source that the routing rule is to be applied to, such as
        /// DeviceMessages. Possible values include: &#39;Invalid&#39;, &#39;DeviceMessages&#39;, &#39;TwinChangeEvents&#39;, &#39;DeviceLifecycleEvents&#39;, &#39;DeviceJobLifecycleEvents&#39;, &#39;DeviceConnectionStateEvents&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "source")]
        public string Source {get; set; }

        /// <summary>
        /// Gets or sets the condition that is evaluated to apply the routing rule. If
        /// no condition is provided, it evaluates to true by default. For grammar,
        /// see:
        /// https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "condition")]
        public string Condition {get; set; }

        /// <summary>
        /// Gets or sets the list of endpoints to which messages that satisfy the
        /// condition are routed. Currently only one endpoint is allowed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endpointNames")]
        public System.Collections.Generic.IList<string> EndpointNames {get; set; }

        /// <summary>
        /// Gets or sets used to specify whether a route is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.Source == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Source");
            }
            if (this.EndpointNames == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EndpointNames");
            }
            if (this.Name != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Name, "^[A-Za-z0-9-._]{1,64}$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "Name", "^[A-Za-z0-9-._]{1,64}$");
                }
            }


            if (this.EndpointNames != null)
            {
                if (this.EndpointNames.Count > 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxItems, "EndpointNames", 1);
                }
                if (this.EndpointNames.Count < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MinItems, "EndpointNames", 1);
                }
            }
        }
    }
}