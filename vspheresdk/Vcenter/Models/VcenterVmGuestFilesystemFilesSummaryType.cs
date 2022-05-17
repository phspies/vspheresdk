using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVmGuestFilesystemFilesSummaryType 
    {
        /// <summary>
        /// The name of the file or directory with any leading directories removed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "filename", Required = Required.AllowNull)]
        public string Filename { get; set; }
        /// <summary>
        /// The type of file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmGuestFilesystemFilesTypeEnum Type { get; set; }
        /// <summary>
        /// The file size in bytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
    }
}
