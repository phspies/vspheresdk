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
    public class ApplianceRecoveryBackupJobBackupRequestTypeA 
    {
        /// <summary>
        /// List of optional parts that will be included in the backup. Use the Parts.list operation to get information about the
        /// supported parts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parts", Required = Required.AllowNull)]
        public IList<string> Parts { get; set; }
        /// <summary>
        /// Password for a backup piece. The backupPassword must adhere to the following password requirements: At least 8
        /// characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At
        /// least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII
        /// characters (for example, no space).
        /// backupPassword If no password then the piece will not be encrypted
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backup_password")]
        public string? BackupPassword { get; set; }
        /// <summary>
        /// Type of backup location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_type", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupJobLocationTypeEnumA LocationType { get; set; }
        /// <summary>
        /// Path or URL of the backup location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Username for the given location.
        /// If unset authentication will not be used for the specified location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_user")]
        public string? LocationUser { get; set; }
        /// <summary>
        /// Password for the given location.
        /// If unset authentication will not be used for the specified location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_password")]
        public string? LocationPassword { get; set; }
        /// <summary>
        /// Custom comment provided by the user.
        /// If unset comment will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string? Comment { get; set; }
        /// <summary>
        /// Option to enable Postgres DB/ VCDB fast backup Setting this true might have performace impact
        /// If unset backup will proceed at slow rate
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fast_backup")]
        public bool? FastBackup { get; set; }
    }
}
