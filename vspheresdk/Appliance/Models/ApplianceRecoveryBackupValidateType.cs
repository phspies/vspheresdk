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
    public class ApplianceRecoveryBackupValidateType 
    {
        /// <summary>
        /// a list of optional parts. Run backup parts APIs to get list of optional parts and description
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parts", Required = Required.AllowNull)]
        public IList<string> Parts { get; set; }
        /// <summary>
        /// a password for a backup piece The backupPassword must adhere to the following password requirements: At least 8
        /// characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At
        /// least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII
        /// characters (for example, no space).
        /// backupPassword If no password then the piece will not be encrypted
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backup_password")]
        public string? BackupPassword { get; set; }
        /// <summary>
        /// a type of location
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_type", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupLocationType LocationType { get; set; }
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
        /// Custom comment
        /// comment an optional comment
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string? Comment { get; set; }
        /// <summary>
        /// Option to enable Postgres DB/ VCDB fast backup. Setting this true might have performace impact
        /// If unset backup will proceed at slow rate
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fast_backup")]
        public bool? FastBackup { get; set; }
    }
}
