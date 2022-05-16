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
    public class ContentLibraryItemStorageInfoTypeA 
    {
        /// <summary>
        /// The storage backing on which this object resides. This might not be the same as the default storage backing associated
        /// with the library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_backing", Required = Required.AllowNull)]
        public ContentLibraryStorageBackingTypeA StorageBacking { get; set; }
        /// <summary>
        /// URIs that identify the file on the storage backing. <p> These URIs may be specific to the backing and may need
        /// interpretation by the client. A client that understands a URI scheme in this list may use that URI to directly access
        /// the file on the storage backing. This can provide high-performance support for file manipulation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_uris", Required = Required.AllowNull)]
        public IList<string> StorageUris { get; set; }
        /// <summary>
        /// A checksum for validating the content of the file. <p> This value can be used to verify that a transfer was completed
        /// without errors.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "checksum_info")]
        public ContentLibraryItemFileChecksumInfoTypeA ChecksumInfo { get; set; }
        /// <summary>
        /// The name of the file. <p> This value will be unique within the library item for each file. It cannot be an empty string.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The file size, in bytes. The file size is the storage used and not the uploaded or provisioned size. For example, when
        /// uploading a disk to a datastore, the amount of storage that the disk consumes may be different from the disk file size.
        /// When the file is not cached, the size is 0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
        /// <summary>
        /// Indicates whether the file is on disk or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cached", Required = Required.AllowNull)]
        public bool Cached { get; set; }
        /// <summary>
        /// The version of this file; incremented when a new copy of the file is uploaded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
    }
}
