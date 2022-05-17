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
    public class EsxSettingsComponentOverrideInfoType 
    {
        /// <summary>
        /// Version of the component override.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Human readable version of the component override.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// Source of the component override.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        public EsxSettingsComponentSourceType Source { get; set; }
        /// <summary>
        /// Note explaining the override.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "note", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Note { get; set; }
    }
}
