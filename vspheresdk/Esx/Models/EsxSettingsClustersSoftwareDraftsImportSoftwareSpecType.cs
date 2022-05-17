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
    public class EsxSettingsClustersSoftwareDraftsImportSoftwareSpecType 
    {
        /// <summary>
        /// Type of the source to import the desired software specification
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_type", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareDraftsSourceType SourceType { get; set; }
        /// <summary>
        /// Location of the software specification file to be imported.
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
        /// The JSON string representing the desired software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "software_spec")]
        public string? SoftwareSpec { get; set; }
    }
}
