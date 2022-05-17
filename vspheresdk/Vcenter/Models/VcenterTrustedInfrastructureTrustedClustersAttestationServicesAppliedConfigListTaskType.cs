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
    public class VcenterTrustedInfrastructureTrustedClustersAttestationServicesAppliedConfigListTaskType 
    {
        /// <summary>
        /// The health of the applied Attestation Service configuration.
        /// If unset, no filtration will be performed by health.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public Dictionary<string,VcenterTrustedInfrastructureTrustedClustersAttestationServicesAppliedConfigHealthEnumType> Health { get; set; }
        /// <summary>
        /// The network address of the Attestation Service configured for use in the Trusted Cluster.
        /// If unset, no filtration will be performed by network address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public Dictionary<string,VcenterTrustedInfrastructureNetworkAddressType> Address { get; set; }
    }
}
