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
    public class ApplianceUpdatePendingPrecheckResultTypeA 
    {
        /// <summary>
        /// Time when this precheck was run
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_time", Required = Required.AllowNull)]
        public DateTime CheckTime { get; set; }
        /// <summary>
        /// Rough estimate of time to install the update (minutes).
        /// estimatedTimeToInstall If unset N/A
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimated_time_to_install")]
        public long? EstimatedTimeToInstall { get; set; }
        /// <summary>
        /// Rough estimate of time to rollback the update (minutes).
        /// estimatedTimeToRollback If unset N/A
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimated_time_to_rollback")]
        public long? EstimatedTimeToRollback { get; set; }
        /// <summary>
        /// Is reboot required to install the update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reboot_required", Required = Required.AllowNull)]
        public bool RebootRequired { get; set; }
        /// <summary>
        /// Lists of the issues and warnings
        /// issues If unset N/A
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issues")]
        public ApplianceNotificationsTypeA Issues { get; set; }
        /// <summary>
        /// List of questions that must be answered to install the update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "questions", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceUpdatePendingQuestionTypeA> Questions { get; set; }
    }
}
