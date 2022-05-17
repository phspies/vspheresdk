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
    public class ApplianceRecoveryBackupJobLocalizableMessageTypeA 
    {
        /// <summary>
        /// Id in message bundle.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// Text in english.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_message", Required = Required.AllowNull)]
        public string DefaultMessage { get; set; }
        /// <summary>
        /// Nested data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "args", Required = Required.AllowNull)]
        public IList<string> Args { get; set; }
    }
}
