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
    public class ApplianceRecoveryBackupSystemNameArchiveInfoTypeA 
    {
        /// <summary>
        /// Time when this backup was completed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Backup location URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// List of parts included in the backup.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parts", Required = Required.AllowNull)]
        public IList<string> Parts { get; set; }
        /// <summary>
        /// The version of the appliance represented by the backup.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// The system name identifier of the appliance represented by the backup.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.recovery.backup.system_name. When operations return a value of this structure as a result, the field will be
        /// an identifier for the resource type: appliance.recovery.backup.system_name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "system_name", Required = Required.AllowNull)]
        public string SystemName { get; set; }
        /// <summary>
        /// Custom comment added by the user for this backup.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment", Required = Required.AllowNull)]
        public string Comment { get; set; }
    }
}
