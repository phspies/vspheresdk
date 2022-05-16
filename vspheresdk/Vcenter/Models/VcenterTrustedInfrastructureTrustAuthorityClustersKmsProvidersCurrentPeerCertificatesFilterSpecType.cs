using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersCurrentPeerCertificatesFilterSpecType 
    {
        /// <summary>
        /// Names that key server must have to match the filter (see CurrentPeerCertificates.Summary.server-name).
        /// If unset or empty, key servers with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server_names")]
        public IList<string> ServerNames { get; set; }
        /// <summary>
        /// Trust status that server certificates must have to match the filter (see CurrentPeerCertificates.Summary.trusted).
        /// If unset, trusted and untrusted server certificates match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trusted")]
        public bool? Trusted { get; set; }
    }
}
