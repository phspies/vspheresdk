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
    public class ContentLibraryItemDownloadsessionFileInfoType 
    {
        /// <summary>
        /// The name of the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The file size, in bytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// The number of bytes that have been transferred by the server so far for making this file prepared for download. This
        /// value may stay at zero till the client starts downloading the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bytes_transferred", Required = Required.AllowNull)]
        public long BytesTransferred { get; set; }
        /// <summary>
        /// The preparation status ({@enum.values PrepareStatus}) of the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ContentLibraryItemDownloadsessionFilePrepareStatusEnumType Status { get; set; }
        /// <summary>
        /// Endpoint at which the file is available for download. The value is valid only when the {@link #status} is {@link
        /// File.PrepareStatus#PREPARED}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "download_endpoint")]
        public ContentLibraryItemTransferEndpointType DownloadEndpoint { get; set; }
        /// <summary>
        /// The checksum information of the file. When the download is complete, you can retrieve the checksum from the {@link
        /// File#get} {@term operation} to verify the checksum for the downloaded file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "checksum_info")]
        public ContentLibraryItemFileChecksumInfoType ChecksumInfo { get; set; }
        /// <summary>
        /// Error message for a failed preparation when the prepare status is {@link File.PrepareStatus#ERROR}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public VapiStdLocalizableMessageType ErrorMessage { get; set; }
    }
}
