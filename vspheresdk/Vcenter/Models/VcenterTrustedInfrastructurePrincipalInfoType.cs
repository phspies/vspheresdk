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
    public class VcenterTrustedInfrastructurePrincipalInfoType 
    {
        /// <summary>
        /// The certificates used by the STS to sign tokens for this vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificates", Required = Required.AllowNull)]
        public Dictionary<string,VcenterTrustedInfrastructureX509CertChainType> Certificates { get; set; }
        /// <summary>
        /// The service which created and signed the security token.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer", Required = Required.AllowNull)]
        public string Issuer { get; set; }
        /// <summary>
        /// The principal used by this vCenter instance to retrieve tokens. Currently this is the vCenter solution user.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "principal", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureStsPrincipalType Principal { get; set; }
        /// <summary>
        /// The user-friednly name of the vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
