using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsClustersSoftwareReportsLastApplyResultApplyStatusType 
    {
        /// <summary>
        /// The status of the {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastApplyResultApplyStatusStatusType Status { get; set; }
        /// <summary>
        /// Progress of the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public CisTaskProgressType Progress { get; set; }
        /// <summary>
        /// Time when the {@term operation} started.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time", Required = Required.AllowNull)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Time when the {@term operation} completed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time", Required = Required.AllowNull)]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// Notifications providing additional information about the status of the {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
