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
    public class EsxSettingsDepotsOfflineCreateSpecType 
    {
        /// <summary>
        /// Description of the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Type of the source from which offline bundle is obtained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_type", Required = Required.AllowNull)]
        public EsxSettingsDepotsOfflineSourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// Location of the depot from which content should be retrieved.
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
        /// Private data saved by the {@link Info#owner} of the depot. It is opaque to vLCM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerdata")]
        public string? Ownerdata { get; set; }
    }
}
