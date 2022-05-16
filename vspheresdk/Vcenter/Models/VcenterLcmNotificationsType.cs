using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterLcmNotificationsType 
    {
        /// <summary>
        /// Info notification messages reported.
        /// Only set if an info was reported by the appliance task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public Dictionary<string,VcenterLcmNotificationType> Info { get; set; }
        /// <summary>
        /// Warning notification messages reported.
        /// Only set if an warning was reported by the appliance task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public Dictionary<string,VcenterLcmNotificationType> Warnings { get; set; }
        /// <summary>
        /// Error notification messages reported.
        /// Only set if an error was reported by the appliance task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public Dictionary<string,VcenterLcmNotificationType> Errors { get; set; }
    }
}
