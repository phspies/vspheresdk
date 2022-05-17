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
    public class ApplianceRecoveryBackupJobDetailsFilterSpecType 
    {
        /// <summary>
        /// Identifiers of backup jobs that can match the filter.
        /// If unset the filter will match all the backup jobs.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// appliance.recovery.backup.job. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: appliance.recovery.backup.job.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobs")]
        public IList<string> Jobs { get; set; }
    }
}
