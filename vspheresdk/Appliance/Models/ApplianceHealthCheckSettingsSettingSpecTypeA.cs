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
    public class ApplianceHealthCheckSettingsSettingSpecTypeA 
    {
        /// <summary>
        /// Health check state of database during manual backup with this option set, the health status of the particular health
        /// check will be reported
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "db_health_check_state_manual_backup", Required = Required.AllowNull)]
        public bool DbHealthCheckStateManualBackup { get; set; }
        /// <summary>
        /// Health check state of database during schedule backup with this option set, the health status of the particular health
        /// check will be reported
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "db_health_check_state_scheduled_backup", Required = Required.AllowNull)]
        public bool DbHealthCheckStateScheduledBackup { get; set; }
    }
}
