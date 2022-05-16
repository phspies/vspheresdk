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
    public class VcenterSystemConfigPscRegistrationInfoTypeA 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the PSC this appliance is registered with.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// The HTTPs port used by the external PSC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port", Required = Required.AllowNull)]
        public long HttpsPort { get; set; }
        /// <summary>
        /// The Single Sign-On domain name of the external PSC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_domain", Required = Required.AllowNull)]
        public string SsoDomain { get; set; }
    }
}
