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
    public class ApplianceTimesyncSetType 
    {
        /// <summary>
        /// Time synchronization mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public ApplianceTimesyncTimeSyncModeType Mode { get; set; }
    }
}
