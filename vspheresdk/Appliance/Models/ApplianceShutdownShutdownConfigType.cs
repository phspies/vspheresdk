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
    public class ApplianceShutdownShutdownConfigType 
    {
        /// <summary>
        /// Shutdown time.
        /// shutdownTime Optional value of pending shutdown time
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "shutdown_time")]
        public DateTime? ShutdownTime { get; set; }
        /// <summary>
        /// The pending shutdown operation. The string values for pending operations can be 'poweroff', 'reboot' or ''.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public string Action { get; set; }
        /// <summary>
        /// The reason behind the shutdown action
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        public string Reason { get; set; }
    }
}
