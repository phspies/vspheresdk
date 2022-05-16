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
    public class VcenterDeploymentMigrateMigrationAssistantSpecTypeA 
    {
        /// <summary>
        /// The HTTPS port being used by Migration Assistant.
        /// If unset, port 9123 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
        /// <summary>
        /// SHA1 thumbprint of the Migration Assistant SSL certificate that will be used for verification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint", Required = Required.AllowNull)]
        public string SslThumbprint { get; set; }
    }
}
