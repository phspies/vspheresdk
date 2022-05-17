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
    public class ApplianceRecoveryRestoreJobCreateType 
    {
        /// <summary>
        /// a password for a backup piece
        /// backupPassword If no password then the piece will not be decrypted
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backup_password")]
        public string? BackupPassword { get; set; }
        /// <summary>
        /// a type of location
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_type", Required = Required.AllowNull)]
        public ApplianceRecoveryRestoreJobLocationTypeEnum LocationType { get; set; }
        /// <summary>
        /// path or url
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// username for location
        /// locationUser User name for this location if login is required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_user")]
        public string? LocationUser { get; set; }
        /// <summary>
        /// password for location
        /// locationPassword Password for the specified user if login is required at this location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_password")]
        public string? LocationPassword { get; set; }
        /// <summary>
        /// Administrators Username for SSO.
        /// If unset SSO authentication will not be used. If the vCenter Server is a management node or an embedded node,
        /// authentication is required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_user_name")]
        public string? SsoAdminUserName { get; set; }
        /// <summary>
        /// The password for SSO admin user.
        /// If unset SSO authentication will not be used. If the vCenter Server is a management node or an embedded node,
        /// authentication is required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_user_password")]
        public string? SsoAdminUserPassword { get; set; }
        /// <summary>
        /// The flag to ignore warnings during restore
        /// If unset, validation warnings will fail the restore operation
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignore_warnings")]
        public bool? IgnoreWarnings { get; set; }
    }
}
