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
    public class ApplianceUpdatePolicyTimeTypeA 
    {
        /// <summary>
        /// weekday to check for updates.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "day", Required = Required.AllowNull)]
        public ApplianceUpdatePolicyDayOfWeekEnumTypeA Day { get; set; }
        /// <summary>
        /// Hour: 0-24
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hour", Required = Required.AllowNull)]
        public long Hour { get; set; }
        /// <summary>
        /// Minute: 0-59
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "minute", Required = Required.AllowNull)]
        public long Minute { get; set; }
    }
}
