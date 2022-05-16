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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersUpdateSpecType 
    {
        /// <summary>
        /// Master key identifier created for the provider.
        /// A unique Key identifier.
        /// 
        /// 
        /// 
        /// If unset, masterKeyId will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_key_id")]
        public string? MasterKeyId { get; set; }
        /// <summary>
        /// Key server associated with this provider.
        /// 
        /// 
        /// If unset, key server configuration will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_server")]
        public VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerUpdateSpecType KeyServer { get; set; }
    }
}
