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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDatetimeConfigType 
    {
        /// <summary>
        /// The Timezone service provides operations to get and set the appliance timezone.
        /// Only set if the Timezone is set in vCenter
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time_zone")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtTimezoneType TimeZone { get; set; }
        /// <summary>
        /// Timesync service provides operations Performs time synchronization configuration.
        /// Only set if the time sync mode is set in vCenter
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time_sync")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtTimesyncType TimeSync { get; set; }
        /// <summary>
        /// Ntp service provides operations Gets NTP configuration status and tests connection to ntp servers.
        /// Only set if the ntp server are set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ntp")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtNtpType Ntp { get; set; }
    }
}
