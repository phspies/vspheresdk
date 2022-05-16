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
    public class ContentConfigurationModelType 
    {
        /// <summary>
        /// Whether automatic synchronization is enabled. <p> When automatic synchronization is enabled, the Content Library Service
        /// will automatically synchronize all subscribed libraries on a daily basis. Subscribed libraries with the {@link
        /// SubscriptionInfo#automaticSyncEnabled} flag turned on will be synchronized every hour between {@link
        /// #automaticSyncStartHour} and {@link #automaticSyncStopHour}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automatic_sync_enabled")]
        public bool? AutomaticSyncEnabled { get; set; }
        /// <summary>
        /// The hour at which the automatic synchronization will start. This value is between 0 (midnight) and 23 inclusive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automatic_sync_start_hour")]
        public long? AutomaticSyncStartHour { get; set; }
        /// <summary>
        /// The hour at which the automatic synchronization will stop. Any active synchronization operation will continue to run,
        /// however no new synchronization operations will be triggered after the stop hour. This value is between 0 (midnight) and
        /// 23 inclusive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automatic_sync_stop_hour")]
        public long? AutomaticSyncStopHour { get; set; }
        /// <summary>
        /// The maximum allowed number of library items to synchronize concurrently from remote libraries. This must be a positive
        /// number. The service may not be able to guarantee the requested concurrency if there is no available capacity. <p> This
        /// setting is global across all subscribed libraries.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "maximum_concurrent_item_syncs")]
        public long? MaximumConcurrentItemSyncs { get; set; }
    }
}
