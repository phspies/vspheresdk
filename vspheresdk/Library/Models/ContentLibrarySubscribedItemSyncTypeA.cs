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
    public class ContentLibrarySubscribedItemSyncTypeA 
    {
        /// <summary>
        /// Whether to synchronize file content as well as metadata. This {@term parameter} applies only if the subscription is
        /// on-demand.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "force_sync_content", Required = Required.AllowNull)]
        public bool ForceSyncContent { get; set; }
        /// <summary>
        /// Whether to synchronize optional files. This {@term parameter} applies to both types of subscriptions on-demand as well
        /// as sync-immediately.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sync_optional_files")]
        public bool? SyncOptionalFiles { get; set; }
    }
}
