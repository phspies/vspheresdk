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
    public class VcenterDeploymentStandalonePscSpecTypeA 
    {
        /// <summary>
        /// The SSO site name used for this PSC.
        /// If unset, default-first-site will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_site_name")]
        public string? SsoSiteName { get; set; }
        /// <summary>
        /// The SSO administrator account password.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_password", Required = Required.AllowNull)]
        public string SsoAdminPassword { get; set; }
        /// <summary>
        /// The SSO domain name to be used to configure this appliance.
        /// If unset, vsphere.local will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_domain_name")]
        public string? SsoDomainName { get; set; }
    }
}
