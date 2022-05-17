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
    public class ContentLibraryStorageBackingType 
    {
        /// <summary>
        /// Type ({@enum.values Type}) of {@link StorageBacking}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ContentLibraryStorageBackingTypeEnum Type { get; set; }
        /// <summary>
        /// Identifier of the datastore used to store the content in the library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore_id")]
        public string? DatastoreId { get; set; }
        /// <summary>
        /// URI identifying the location used to store the content in the library. <p> The following URI formats are supported: <p>
        /// vSphere 6.5 <ul> <li>nfs://server/path?version=4 (for vCenter Server Appliance only) - Specifies an NFS Version 4
        /// server.</li> <li>nfs://server/path (for vCenter Server Appliance only) - Specifies an NFS Version 3 server. The
        /// nfs://server:/path format is also supported.</li> <li>smb://server/path - Specifies an SMB server or Windows share.</li>
        /// </ul> <p> vSphere 6.0 Update 1 <ul> <li>nfs://server:/path (for vCenter Server Appliance only)</li>
        /// <li>file://unc-server/path (for vCenter Server for Windows only)</li> <li>file:///mount/point (for vCenter Server
        /// Appliance only) - Local file URIs are supported only when the path is a local mount point for an NFS file system. Use of
        /// file URIs is strongly discouraged. Instead, use an NFS URI to specify the remote file system.</li> </ul> <p> vSphere 6.0
        /// <ul> <li>nfs://server:/path (for vCenter Server Appliance only)</li> <li>file://unc-server/path (for vCenter Server for
        /// Windows only)</li> <li>file:///path - Local file URIs are supported but strongly discouraged because it may interfere
        /// with the performance of vCenter Server.</li> </ul>
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_uri")]
        public string? StorageUri { get; set; }
    }
}
