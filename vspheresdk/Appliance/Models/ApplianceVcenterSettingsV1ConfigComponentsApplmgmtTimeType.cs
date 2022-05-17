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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtTimeType 
    {
        /// <summary>
        /// Time to query for updates Format: HH:MM:SS Military (24 hour) Time Format
        /// Only set if hour is present in SoftwareUpdatePolicy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public string? Hour { get; set; }
        /// <summary>
        /// Time to query for updates Format: HH:MM:SS Military (24 hour) Time Format
        /// Only set if minute is present in SoftwareUpdatePolicy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public string? Minute { get; set; }
        /// <summary>
        /// Day to query for updates
        /// Only set if minute is present in SoftwareUpdatePolicy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "day")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtTimeUpdateDayType Day { get; set; }
    }
}
