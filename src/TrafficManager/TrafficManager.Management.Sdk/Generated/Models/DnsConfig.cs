// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Models
{
    using System.Linq;

    /// <summary>
    /// Class containing DNS settings in a Traffic Manager profile.
    /// </summary>
    public partial class DnsConfig
    {
        /// <summary>
        /// Initializes a new instance of the DnsConfig class.
        /// </summary>
        public DnsConfig()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DnsConfig class.
        /// </summary>

        /// <param name="relativeName">The relative DNS name provided by this Traffic Manager profile. This value
        /// is combined with the DNS domain name used by Azure Traffic Manager to form
        /// the fully-qualified domain name (FQDN) of the profile.
        /// </param>

        /// <param name="fqdn">The fully-qualified domain name (FQDN) of the Traffic Manager profile. This
        /// is formed from the concatenation of the RelativeName with the DNS domain
        /// used by Azure Traffic Manager.
        /// </param>

        /// <param name="ttl">The DNS Time-To-Live (TTL), in seconds. This informs the local DNS
        /// resolvers and DNS clients how long to cache DNS responses provided by this
        /// Traffic Manager profile.
        /// </param>
        public DnsConfig(string relativeName = default(string), string fqdn = default(string), long? ttl = default(long?))

        {
            this.RelativeName = relativeName;
            this.Fqdn = fqdn;
            this.Ttl = ttl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the relative DNS name provided by this Traffic Manager
        /// profile. This value is combined with the DNS domain name used by Azure
        /// Traffic Manager to form the fully-qualified domain name (FQDN) of the
        /// profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "relativeName")]
        public string RelativeName {get; set; }

        /// <summary>
        /// Gets the fully-qualified domain name (FQDN) of the Traffic Manager profile.
        /// This is formed from the concatenation of the RelativeName with the DNS
        /// domain used by Azure Traffic Manager.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fqdn")]
        public string Fqdn {get; private set; }

        /// <summary>
        /// Gets or sets the DNS Time-To-Live (TTL), in seconds. This informs the local
        /// DNS resolvers and DNS clients how long to cache DNS responses provided by
        /// this Traffic Manager profile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ttl")]
        public long? Ttl {get; set; }
    }
}