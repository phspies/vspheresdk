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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersCreateTaskType 
    {
        /// <summary>
        /// Name of the provider.
        /// A unique string chosen by the client.
        /// 
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.trusted_infrastructure.trust_authority_clusters.kms.Provider. When operations return a value of this structure
        /// as a result, the field will be an identifier for the resource type:
        /// vcenter.trusted_infrastructure.trust_authority_clusters.kms.Provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public string Provider { get; set; }
        /// <summary>
        /// Master key ID created for the provider.
        /// A unique Key ID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_key_id", Required = Required.AllowNull)]
        public string MasterKeyId { get; set; }
        /// <summary>
        /// Key server associated with this Provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_server", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerCreateSpecType KeyServer { get; set; }
    }
}
