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
    public class ContentLibraryModelTypeA 
    {
        /// <summary>
        /// An identifier which uniquely identifies this {@name LibraryModel}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// The date and time when this library was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_time")]
        public DateTime? CreationTime { get; set; }
        /// <summary>
        /// A human-readable description for this library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The date and time when this library was last updated. <p> This {@term field} is updated automatically when the library
        /// properties are changed. This {@term field} is not affected by adding, removing, or modifying a library item or its
        /// content within the library. Tagging the library or syncing the subscribed library does not alter this {@term field}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified_time")]
        public DateTime? LastModifiedTime { get; set; }
        /// <summary>
        /// The date and time when this library was last synchronized. <p> This {@term field} applies only to subscribed libraries.
        /// It is updated every time a synchronization is triggered on the library. The value is {@term unset} for a local library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_sync_time")]
        public DateTime? LastSyncTime { get; set; }
        /// <summary>
        /// The name of the library. <p> A Library is identified by a human-readable name. Library names cannot be undefined or an
        /// empty string. Names do not have to be unique.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The list of default storage backings which are available for this library. <p> A {@link StorageBacking} defines a
        /// default storage location which can be used to store files for library items in this library. Some library items, for
        /// instance, virtual machine template items, support files that may be distributed across various storage backings. One or
        /// more item files may or may not be located on the default storage backing. <p> Multiple default storage locations are not
        /// currently supported but may become supported in future releases.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_backings")]
        public Dictionary<string,ContentLibraryStorageBackingTypeA> StorageBackings { get; set; }
        /// <summary>
        /// The type ({@enum.values LibraryModel.LibraryType}) of this library. <p> This value can be used to determine what
        /// additional services and information can be available for this library. This {@term field} is not used for the {@code
        /// create} and {@code update} {@term operations}. It will always be present in the result of a {@code get} {@term
        /// operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ContentLibraryModelLibraryTypeEnumA Type { get; set; }
        /// <summary>
        /// Defines various optimizations and optimization parameters applied to this library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "optimization_info")]
        public ContentLibraryOptimizationInfoTypeA OptimizationInfo { get; set; }
        /// <summary>
        /// A version number which is updated on metadata changes. This value allows clients to detect concurrent updates and
        /// prevent accidental clobbering of data. <p> This value represents a number which is incremented every time library
        /// properties, such as name or description, are changed. It is not incremented by changes to a library item within the
        /// library, including adding or removing items. It is also not affected by tagging the library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Defines how this library is published so that it can be subscribed to by a remote subscribed library. <p> The {@link
        /// PublishInfo} defines where and how the metadata for this local library is accessible. A local library is only published
        /// publically if {@link PublishInfo#published} is {@code true}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "publish_info")]
        public ContentLibraryPublishInfoTypeA PublishInfo { get; set; }
        /// <summary>
        /// Defines the subscription behavior for this Library. <p> The {@link SubscriptionInfo} defines how this subscribed library
        /// synchronizes to a remote source. Setting the value will determine the remote source to which the library synchronizes,
        /// and how. Changing the subscription will result in synchronizing to a new source. If the new source differs from the old
        /// one, the old library items and data will be lost. Setting {@link SubscriptionInfo#automaticSyncEnabled} to false will
        /// halt subscription but will not remove existing cached data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription_info")]
        public ContentLibrarySubscriptionInfoTypeA SubscriptionInfo { get; set; }
        /// <summary>
        /// The unique identifier of the vCenter server where the library exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server_guid")]
        public string? ServerGuid { get; set; }
        /// <summary>
        /// Represents the security policy applied to this library. <p> Setting the {@term field} will make the library secure. This
        /// field is ignored in {@code update} {@term operation} if {@link #unsetSecurityPolicyId} is set to {@code true}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "security_policy_id")]
        public string? SecurityPolicyId { get; set; }
        /// <summary>
        /// This represents the intent of the change to {@link #securityPolicyId} in {@code update} {@term operation}. <p> If this
        /// field is set to {@code true}, any security policy applied to the library will be removed. If this field is set to {@code
        /// false}, any security policy applied to library will be changed to the value specified in {@link #securityPolicyId}, if
        /// any.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "unset_security_policy_id")]
        public bool? UnsetSecurityPolicyId { get; set; }
    }
}
