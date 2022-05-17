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
    public class ApplianceRecoveryBackupSchedulesRunType 
    {
        /// <summary>
        /// field that specifies the description for the backup.
        /// If unset the backup will have an empty comment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string? Comment { get; set; }
    }
}
