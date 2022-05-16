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
    public class VcenterDeploymentNotificationType 
    {
        /// <summary>
        /// The notification id.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The time the notification was raised/found.
        /// Only set if the time information is available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public DateTime? Time { get; set; }
        /// <summary>
        /// The notification message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Message { get; set; }
        /// <summary>
        /// The resolution message, if any.
        /// Only set for warnings and errors.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public VapiStdLocalizableMessageType Resolution { get; set; }
    }
}
