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
    public class EsxHclNotificationType 
    {
        /// <summary>
        /// The notification id.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The time the notification was raised/found.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time", Required = Required.AllowNull)]
        public DateTime Time { get; set; }
        /// <summary>
        /// The notification message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Message { get; set; }
        /// <summary>
        /// The resolution message, if any.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public VapiStdLocalizableMessageType Resolution { get; set; }
    }
}
