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
    public class EsxSettingsClustersSoftwareDraftsMetadataType 
    {
        /// <summary>
        /// Owner of the software draft.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner", Required = Required.AllowNull)]
        public string Owner { get; set; }
        /// <summary>
        /// Status of the software draft.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareDraftsStatusType Status { get; set; }
        /// <summary>
        /// Creation time of the software draft.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_time", Required = Required.AllowNull)]
        public DateTime CreationTime { get; set; }
    }
}
