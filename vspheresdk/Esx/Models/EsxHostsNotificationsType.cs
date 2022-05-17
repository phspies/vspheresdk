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
    public class EsxHostsNotificationsType 
    {
        /// <summary>
        /// Info notification messages reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public Dictionary<string,EsxHostsNotificationType> Info { get; set; }
        /// <summary>
        /// Warning notification messages reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public Dictionary<string,EsxHostsNotificationType> Warnings { get; set; }
        /// <summary>
        /// Error notification messages reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public Dictionary<string,EsxHostsNotificationType> Errors { get; set; }
    }
}
