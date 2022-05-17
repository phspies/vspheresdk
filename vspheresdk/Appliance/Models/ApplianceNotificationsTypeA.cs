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
    public class ApplianceNotificationsTypeA 
    {
        /// <summary>
        /// Info notification messages reported.
        /// Only set if an info was reported by the appliance task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public Dictionary<string,ApplianceNotificationTypeA> Info { get; set; }
        /// <summary>
        /// Warning notification messages reported.
        /// Only set if an warning was reported by the appliance task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public Dictionary<string,ApplianceNotificationTypeA> Warnings { get; set; }
        /// <summary>
        /// Error notification messages reported.
        /// Only set if an error was reported by the appliance task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public Dictionary<string,ApplianceNotificationTypeA> Errors { get; set; }
    }
}
