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
    public class EsxSettingsDepotsSyncScheduleSetType 
    {
        /// <summary>
        /// Flag indicating whether automatic sync is enabled or not
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// The schedule to check for new updates.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedule")]
        public EsxSettingsDepotsSyncScheduleScheduleType Schedule { get; set; }
        /// <summary>
        /// Email addresses to which the notification will be sent. If empty, no notification is sent.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_addresses", Required = Required.AllowNull)]
        public IList<string> EmailAddresses { get; set; }
    }
}
