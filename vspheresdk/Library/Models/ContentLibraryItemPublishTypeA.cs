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
    public class ContentLibraryItemPublishTypeA 
    {
        /// <summary>
        /// Whether to synchronize file content as well as metadata. This {@term parameter} applies only if the subscription is
        /// on-demand.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "force_sync_content", Required = Required.AllowNull)]
        public bool ForceSyncContent { get; set; }
        /// <summary>
        /// The list of subscriptions to publish this library item to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptions")]
        public Dictionary<string,ContentLibraryItemDestinationSpecTypeA> Subscriptions { get; set; }
    }
}
