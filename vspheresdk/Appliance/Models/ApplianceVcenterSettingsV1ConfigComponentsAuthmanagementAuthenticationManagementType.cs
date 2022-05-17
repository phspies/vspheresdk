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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementAuthenticationManagementType 
    {
        /// <summary>
        /// List of Privileges.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "privileges", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementPrivilegesType> Privileges { get; set; }
        /// <summary>
        /// List of Global Permission.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "global_permissions", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementGlobalPermissionType> GlobalPermissions { get; set; }
        /// <summary>
        /// List of Roles.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementRolesType> Roles { get; set; }
        /// <summary>
        /// Password Policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementPasswordPolicyType PasswordPolicy { get; set; }
        /// <summary>
        /// Token Policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementTokenPolicyType TokenPolicy { get; set; }
        /// <summary>
        /// Lockout Policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "lockout_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementLockoutPolicyType LockoutPolicy { get; set; }
    }
}
