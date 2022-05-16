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
    public class ContentLibraryPublishInfoTypeA 
    {
        /// <summary>
        /// Indicates how a subscribed library should authenticate ({@enum.values AuthenticationMethod}) to the published library
        /// endpoint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authentication_method")]
        public ContentLibraryPublishInfoAuthenticationMethodTypeA AuthenticationMethod { get; set; }
        /// <summary>
        /// Whether the local library is published.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "published")]
        public bool? Published { get; set; }
        /// <summary>
        /// The URL to which the library metadata is published by the Content Library Service. <p> This value can be used to set the
        /// {@link SubscriptionInfo#subscriptionUrl} property when creating a subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "publish_url")]
        public string? PublishUrl { get; set; }
        /// <summary>
        /// The username to require for authentication.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string? UserName { get; set; }
        /// <summary>
        /// The new password to require for authentication.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// The current password to verify. This {@term field} is available starting in vSphere 6.7.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_password")]
        public string? CurrentPassword { get; set; }
        /// <summary>
        /// Whether library and library item metadata are persisted in the storage backing as JSON files. This flag only applies if
        /// the local library is published. <p> Enabling JSON persistence allows you to synchronize a subscribed library manually
        /// instead of over HTTP. You copy the local library content and metadata to another storage backing manually and then
        /// create a subscribed library referencing the location of the library JSON file in the {@link
        /// SubscriptionInfo#subscriptionUrl}. When the subscribed library's storage backing matches the subscription URL, files do
        /// not need to be copied to the subscribed library. <p> For a library backed by a datastore, the library JSON file will be
        /// stored at the path contentlib-{library_id}/lib.json on the datastore. <p> For a library backed by a remote file system,
        /// the library JSON file will be stored at {library_id}/lib.json in the remote file system path.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "persist_json_enabled")]
        public bool? PersistJsonEnabled { get; set; }
    }
}
