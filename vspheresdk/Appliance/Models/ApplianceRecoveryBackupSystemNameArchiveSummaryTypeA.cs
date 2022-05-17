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
    public class ApplianceRecoveryBackupSystemNameArchiveSummaryTypeA 
    {
        /// <summary>
        /// Backup archive identifier.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.recovery.backup.system_name.archive. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: appliance.recovery.backup.system_name.archive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "archive", Required = Required.AllowNull)]
        public string Archive { get; set; }
        /// <summary>
        /// Time when this backup was started.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// The version of the appliance represented by the backup archive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Custom comment added by the user for this backup.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment", Required = Required.AllowNull)]
        public string Comment { get; set; }
    }
}
