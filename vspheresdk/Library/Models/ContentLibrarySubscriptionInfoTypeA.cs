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
    public class ContentLibrarySubscriptionInfoTypeA 
    {
        /// <summary>
        /// Indicate how the subscribed library should authenticate ({@enum.values AuthenticationMethod}) with the published library
        /// endpoint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authentication_method")]
        public ContentLibrarySubscriptionInfoAuthenticationMethodTypeA AuthenticationMethod { get; set; }
        /// <summary>
        /// Whether the library should participate in automatic library synchronization. In order for automatic synchronization to
        /// happen, the global {@link ConfigurationModel#automaticSyncEnabled} option must also be true. The subscription is still
        /// active even when automatic synchronization is turned off, but synchronization is only activated with an explicit call to
        /// {@link SubscribedLibrary#sync} or {@link SubscribedItem#sync}. In other words, manual synchronization is still available
        /// even when automatic synchronization is disabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automatic_sync_enabled")]
        public bool? AutomaticSyncEnabled { get; set; }
        /// <summary>
        /// Indicates whether a library item's content will be synchronized only on demand. <p> If this is set to {@code true}, then
        /// the library item's metadata will be synchronized but the item's content (its files) will not be synchronized. The
        /// Content Library Service will synchronize the content upon request only. This can cause the first use of the content to
        /// have a noticeable delay. <p> Items without synchronized content can be forcefully synchronized in advance using the
        /// {@link SubscribedItem#sync} call with {@param.name forceSyncContent} set to true. Once content has been synchronized,
        /// the content can removed with the {@link SubscribedItem#evict} call. <p> If this value is set to {@code false}, all
        /// content will be synchronized in advance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "on_demand")]
        public bool? OnDemand { get; set; }
        /// <summary>
        /// The password to use when authenticating. <p> The password must be set when using a password-based authentication method;
        /// empty strings are not allowed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// An optional SHA-1 hash of the SSL certificate for the remote endpoint. <p> If this value is defined the SSL certificate
        /// will be verified by comparing it to the SSL thumbprint. The SSL certificate must verify against the thumbprint. When
        /// specified, the standard certificate chain validation behavior is not used. The certificate chain is validated normally
        /// if this value is {@term unset}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// The URL of the endpoint where the metadata for the remotely published library is being served. <p> This URL can be the
        /// {@link PublishInfo#publishUrl} of the published library (for example, https://server/path/lib.json). <p> If the source
        /// content comes from a published library with {@link PublishInfo#persistJsonEnabled}, the subscription URL can be a URL
        /// pointing to the library JSON file on a datastore or remote file system. The supported formats are: <p> vSphere 6.5 <ul>
        /// <li>ds:///vmfs/volumes/{uuid}/mylibrary/lib.json (for datastore)</li> <li>nfs://server/path/mylibrary/lib.json (for
        /// NFSv3 server on vCenter Server Appliance)</li> <li>nfs://server/path/mylibrary/lib.json?version=4 (for NFSv4 server on
        /// vCenter Server Appliance) </li> <li>smb://server/path/mylibrary/lib.json (for SMB server)</li> </ul> <p> vSphere 6.0
        /// <ul> <li>file://server/mylibrary/lib.json (for UNC server on vCenter Server for Windows)</li>
        /// <li>file:///path/mylibrary/lib.json (for local file system)</li> </ul> <p> When you specify a DS subscription URL, the
        /// datastore must be on the same vCenter Server as the subscribed library. When you specify an NFS or SMB subscription URL,
        /// the {@link StorageBacking#storageUri} of the subscribed library must be on the same remote file server and should share
        /// a common parent path with the subscription URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription_url")]
        public string? SubscriptionUrl { get; set; }
        /// <summary>
        /// The username to use when authenticating. <p> The username must be set when using a password-based authentication method.
        /// Empty strings are allowed for usernames.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string? UserName { get; set; }
        /// <summary>
        /// Information about the source published library. This {@term field} will be set for a subscribed library which is
        /// associated with a subscription of the published library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_info")]
        public ContentLibrarySourceInfoTypeA SourceInfo { get; set; }
    }
}
