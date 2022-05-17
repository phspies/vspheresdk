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
    public class ContentLibraryItemUpdatesessionFileInfoType 
    {
        /// <summary>
        /// The name of the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The source type ({@enum.values SourceType}) from which the file is being retrieved. This may be {@link SourceType#NONE}
        /// if the file is not being changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_type", Required = Required.AllowNull)]
        public ContentLibraryItemUpdatesessionFileSourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// The file size, in bytes as received by the server. This {@term field} is guaranteed to be set when the server has
        /// completely received the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// The checksum information of the file received by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "checksum_info")]
        public ContentLibraryItemFileChecksumInfoType ChecksumInfo { get; set; }
        /// <summary>
        /// A source endpoint from which to retrieve the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_endpoint")]
        public ContentLibraryItemTransferEndpointType SourceEndpoint { get; set; }
        /// <summary>
        /// An upload endpoint to which the client can push the content.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upload_endpoint")]
        public ContentLibraryItemTransferEndpointType UploadEndpoint { get; set; }
        /// <summary>
        /// The number of bytes of this file that have been received by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bytes_transferred", Required = Required.AllowNull)]
        public long BytesTransferred { get; set; }
        /// <summary>
        /// The transfer status ({@enum.values TransferStatus}) of this file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ContentLibraryItemTransferStatusEnumType Status { get; set; }
        /// <summary>
        /// Details about the transfer error.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public VapiStdLocalizableMessageType ErrorMessage { get; set; }
        /// <summary>
        /// Whether or not the file will be kept in storage upon update session completion. The flag is true for most files, and
        /// false for metadata files such as manifest and certificate file of update session with library item type OVF. Any file
        /// with {@link Info#keepInStorage} set to false will not show up in the list of files returned from {@link
        /// content.library.item.File#list} upon update session completion.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "keep_in_storage")]
        public bool? KeepInStorage { get; set; }
    }
}
