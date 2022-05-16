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
    public class VcenterDeploymentInstallInitialConfigRemotePscThumbprintRemoteSpecTypeA 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the remote PSC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// The HTTPS port of the remote PSC.
        /// If unset, port 443 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
    }
}
