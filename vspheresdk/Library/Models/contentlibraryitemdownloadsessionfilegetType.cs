using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLibraryItemDownloadsessionFileGetType 
    {
        /// <summary>
        /// Name of the file requested.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.AllowNull)]
        public string FileName { get; set; }
    }
}
