using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsVsphereuiconfigurationVsphereUiconfigurationType 
    {
        /// <summary>
        /// Property to configure the IDPConfiguration view, with this enabled, user will be able to view and configure IDP
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable_IDP_configuration")]
        public bool? EnableIdpconfiguration { get; set; }
        /// <summary>
        /// Property to enable CloudAdminRoleProtection in the UI
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable_cloud_admin_role_protection")]
        public bool? EnableCloudAdminRoleProtection { get; set; }
    }
}
