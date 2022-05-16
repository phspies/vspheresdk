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
    public class ContentLibraryItemUpdatesessionFileAddSpecTypeA 
    {
        /// <summary>
        /// The name of the file being uploaded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The source type ({@enum.values SourceType}) from which the file content will be retrieved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_type", Required = Required.AllowNull)]
        public ContentLibraryItemUpdatesessionFileSourceTypeA SourceType { get; set; }
        /// <summary>
        /// Location from which the Content Library Service will fetch the file, rather than requiring a client to upload the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_endpoint")]
        public ContentLibraryItemTransferEndpointTypeA SourceEndpoint { get; set; }
        /// <summary>
        /// The file size, in bytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// The checksum of the file. If specified, the server will verify the checksum once the file is received. If there is a
        /// mismatch, the upload will fail. For ova files, this value should not be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "checksum_info")]
        public ContentLibraryItemFileChecksumInfoTypeA ChecksumInfo { get; set; }
    }
}
