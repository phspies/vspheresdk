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
    public class EsxSettingsDepotsOfflineInfoType 
    {
        /// <summary>
        /// Description of the depot. If not set during import, it will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Type of the source from which offline depot is obtained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_type", Required = Required.AllowNull)]
        public EsxSettingsDepotsOfflineSourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// Location of the depot from which content is retrieved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string? Location { get; set; }
        /// <summary>
        /// File identifier returned by the file upload endpoint after file is uploaded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_id")]
        public string? FileId { get; set; }
        /// <summary>
        /// Time when the depot was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "create_time", Required = Required.AllowNull)]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// Name of the user creating the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string? Owner { get; set; }
        /// <summary>
        /// Private data saved by the {@name #owner} of depot. It is opaque to vLCM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerdata")]
        public string? Ownerdata { get; set; }
    }
}
