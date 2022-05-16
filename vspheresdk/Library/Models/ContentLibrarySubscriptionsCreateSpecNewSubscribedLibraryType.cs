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
    public class ContentLibrarySubscriptionsCreateSpecNewSubscribedLibraryType 
    {
        /// <summary>
        /// Name of the subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The list of default storage backings for this library. <p> The list must contain exactly one storage backing. Multiple
        /// default storage locations are not currently supported but may become supported in future releases.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_backings", Required = Required.AllowNull)]
        public Dictionary<string,ContentLibraryStorageBackingType> StorageBackings { get; set; }
        /// <summary>
        /// Specifies whether the library should participate in automatic library synchronization.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automatic_sync_enabled", Required = Required.AllowNull)]
        public bool AutomaticSyncEnabled { get; set; }
        /// <summary>
        /// Specifies whether a library item's content will be synchronized only on demand.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "on_demand", Required = Required.AllowNull)]
        public bool OnDemand { get; set; }
    }
}
