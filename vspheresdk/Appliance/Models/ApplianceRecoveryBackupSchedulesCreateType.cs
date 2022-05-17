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
    public class ApplianceRecoveryBackupSchedulesCreateType 
    {
        /// <summary>
        /// Identifier of the schedule
        /// The parameter must be an identifier for the resource type: appliance.recovery.backup.schedule.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedule", Required = Required.AllowNull)]
        public string Schedule { get; set; }
        /// <summary>
        /// CreateSpec Structure
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupSchedulesCreateSpecType Spec { get; set; }
    }
}
