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
    public class ContentLibraryItemModelType 
    {
        /// <summary>
        /// A unique identifier for this library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The identifier of the {@link LibraryModel} to which this item belongs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_id")]
        public string? LibraryId { get; set; }
        /// <summary>
        /// The latest version of the file content list of this library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_version")]
        public string? ContentVersion { get; set; }
        /// <summary>
        /// The date and time when this library item was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_time")]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// A human-readable description for this library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The date and time when the metadata for this library item was last changed. <p> This {@term field} is affected by
        /// changes to the properties or file content of this item. It is not modified by changes to the tags of the item, or by
        /// changes to the library which owns this item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified_time")]
        public DateTime? LastModifiedTime { get; set; }
        /// <summary>
        /// The date and time when this library item was last synchronized. <p> This {@term field} is updated every time a
        /// synchronization is triggered on the library item, including when a synchronization is triggered on the library to which
        /// this item belongs. The value is {@term unset} for a library item that belongs to a local library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_sync_time")]
        public DateTime? LastSyncTime { get; set; }
        /// <summary>
        /// A version number for the metadata of this library item. <p> This value is incremented with each change to the metadata
        /// of this item. Changes to name, description, and so on will increment this value. The value is not incremented by changes
        /// to the content or tags of the item or the library which owns it.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata_version")]
        public string? MetadataVersion { get; set; }
        /// <summary>
        /// A human-readable name for this library item. <p> The name may not be {@term unset} or an empty string. The name does not
        /// have to be unique, even within the same library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The status that indicates whether the library item is on disk or not. The library item is cached when all its files are
        /// on disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cached")]
        public bool? Cached { get; set; }
        /// <summary>
        /// The library item size, in bytes. The size is the sum of the size used on the storage backing for all the files in the
        /// item. When the library item is not cached, the size is 0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// An optional type identifier which indicates the type adapter plugin to use. <p> This {@term field} may be set to a
        /// non-empty string value that corresponds to an identifier supported by a type adapter plugin present in the Content
        /// Library Service. A type adapter plugin, if present for the specified type, can provide additional information and
        /// services around the item content. A type adapter can guide the upload process by creating file entries that are in need
        /// of being uploaded to complete an item. <p> The types and plugins supported by the Content Library Service can be queried
        /// using the {@link Type} {@term service}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// A version number that is updated on metadata changes. This value is used to validate update requests to provide
        /// optimistic concurrency of changes. <p> This value represents a number that is incremented every time library item
        /// properties, such as name or description, are changed. It is not incremented by changes to the file content of the
        /// library item, including adding or removing files. It is also not affected by tagging the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// The identifier of the {@link ItemModel} to which this item is synchronized to if the item belongs to a subscribed
        /// library. The value is {@term unset} for a library item that belongs to a local library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_id")]
        public string? SourceId { get; set; }
        /// <summary>
        /// Shows the security compliance of {@link ItemModel}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "security_compliance")]
        public bool? SecurityCompliance { get; set; }
        /// <summary>
        /// Certificate verification status and {@link ItemModel}'s signing certificate . Currently, this field is available only in
        /// following cases 1. This item belongs to a secure content library 2. The item is of type ovf.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_verification_info")]
        public ContentLibraryItemCertificateVerificationInfoType CertificateVerificationInfo { get; set; }
    }
}
