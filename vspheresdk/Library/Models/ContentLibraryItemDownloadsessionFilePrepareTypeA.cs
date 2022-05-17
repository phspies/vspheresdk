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
    public class ContentLibraryItemDownloadsessionFilePrepareTypeA 
    {
        /// <summary>
        /// Name of the file requested for download.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.AllowNull)]
        public string FileName { get; set; }
        /// <summary>
        /// Endpoint type request, one of {@enum.values EndpointType}. This will determine the type of the {@link
        /// File.Info#downloadEndpoint} that is generated when the file is prepared. The {@link EndpointType#DIRECT} is only
        /// available to users who have the ContentLibrary.ReadStorage privilege.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "endpoint_type")]
        public ContentLibraryItemDownloadsessionFileEndpointTypeEnumA EndpointType { get; set; }
    }
}
