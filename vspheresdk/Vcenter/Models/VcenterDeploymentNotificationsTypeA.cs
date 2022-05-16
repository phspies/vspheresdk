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
    public class VcenterDeploymentNotificationsTypeA 
    {
        /// <summary>
        /// Info notification messages reported.
        /// Only set if an info was reported by the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public Dictionary<string,VcenterDeploymentNotificationTypeA> Info { get; set; }
        /// <summary>
        /// Warning notification messages reported.
        /// Only set if an warning was reported by the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public Dictionary<string,VcenterDeploymentNotificationTypeA> Warnings { get; set; }
        /// <summary>
        /// Error notification messages reported.
        /// Only set if an error was reported by the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public Dictionary<string,VcenterDeploymentNotificationTypeA> Errors { get; set; }
    }
}
