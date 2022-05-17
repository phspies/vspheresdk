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
    public class ApplianceRecoveryReconciliationJobCreateSpecType 
    {
        /// <summary>
        /// Administrators username for SSO.
        /// If unset SSO authentication will not be used. If the vCenter Server is a management node or an embedded node,
        /// authentication is required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_user_name")]
        public string? SsoAdminUserName { get; set; }
        /// <summary>
        /// Password for SSO admin user.
        /// If unset SSO authentication will not be used. If the vCenter Server is a management node or an embedded node,
        /// authentication is required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_user_password")]
        public string? SsoAdminUserPassword { get; set; }
        /// <summary>
        /// Flag indicating whether warnings should be ignored during reconciliation.
        /// If unset, validation warnings will fail the reconciliation operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignore_warnings")]
        public bool? IgnoreWarnings { get; set; }
    }
}
