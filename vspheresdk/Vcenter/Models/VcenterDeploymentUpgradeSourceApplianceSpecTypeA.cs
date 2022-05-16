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
    public class VcenterDeploymentUpgradeSourceApplianceSpecTypeA 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the source appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// The HTTPS port of the source appliance.
        /// If unset, port 443 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
        /// <summary>
        /// SHA1 thumbprint of the server SSL certificate will be used for verification.
        /// This field is only relevant if Upgrade.SourceApplianceSpec.ssl-verify is unset or has the value true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// SSL verification should be enabled or disabled for the source appliance validations. By default it is enabled and will
        /// use SSL certificate for verification. If thumbprint is provided, will use thumbprint for the verification.
        /// If unset, ssl_verify true will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_verify")]
        public bool? SslVerify { get; set; }
        /// <summary>
        /// The SSO administrator account on the source appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_username", Required = Required.AllowNull)]
        public string SsoAdminUsername { get; set; }
        /// <summary>
        /// The SSO administrator account password.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_password", Required = Required.AllowNull)]
        public string SsoAdminPassword { get; set; }
        /// <summary>
        /// The password of the root user on the source appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "root_password", Required = Required.AllowNull)]
        public string RootPassword { get; set; }
        /// <summary>
        /// Appliance SSH verification should be enabled or disabled. By default it is disabled and will not use any verification.
        /// If thumbprint is provided, thumbprint verification will be performed.
        /// If unset, ssh_verify true will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssh_verify")]
        public bool? SshVerify { get; set; }
        /// <summary>
        /// MD5 thumbprint of the server SSH key will be used for verification.
        /// This field is only relevant if Upgrade.SourceApplianceSpec.ssh-verify is unset or has the value true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssh_thumbprint")]
        public string? SshThumbprint { get; set; }
    }
}
