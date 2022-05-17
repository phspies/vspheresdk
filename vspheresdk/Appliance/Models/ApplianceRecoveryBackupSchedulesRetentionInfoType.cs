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
    public class ApplianceRecoveryBackupSchedulesRetentionInfoType 
    {
        /// <summary>
        /// Number of backups which should be retained. If retention is not set, all the backups will be retained forever.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_count", Required = Required.AllowNull)]
        public long MaxCount { get; set; }
    }
}
