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
    public class EsxSettingsClustersSoftwareDraftsInfoType 
    {
        /// <summary>
        /// Metadata about the software draft.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareDraftsMetadataType Metadata { get; set; }
        /// <summary>
        /// Software specification associated with the draft.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "software", Required = Required.AllowNull)]
        public EsxSettingsSoftwareInfoType Software { get; set; }
    }
}
