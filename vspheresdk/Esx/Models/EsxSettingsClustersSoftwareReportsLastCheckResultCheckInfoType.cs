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
    public class EsxSettingsClustersSoftwareReportsLastCheckResultCheckInfoType 
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check", Required = Required.AllowNull)]
        public string Check { get; set; }
        /// <summary>
        /// The check name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Name { get; set; }
        /// <summary>
        /// Human-readable check description.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
    }
}
