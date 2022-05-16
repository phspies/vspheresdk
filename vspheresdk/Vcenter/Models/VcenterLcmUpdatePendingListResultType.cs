using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterLcmUpdatePendingListResultType 
    {
        /// <summary>
        /// Time when the software depo was last checked.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_check_time", Required = Required.AllowNull)]
        public DateTime LastCheckTime { get; set; }
        /// <summary>
        /// Number of pending updates
        /// Only set if there are available updates
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_count")]
        public long? UpdateCount { get; set; }
        /// <summary>
        /// Number of pending upgrades
        /// Only set if there are available upgrades
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_count")]
        public long? UpgradeCount { get; set; }
        /// <summary>
        /// List of pending update details
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "updates", Required = Required.AllowNull)]
        public Dictionary<string,VcenterLcmUpdatePendingSummaryType> Updates { get; set; }
        /// <summary>
        /// Lists of issues encountered during pending updates retrieval.
        /// set if any issues encountered.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issues")]
        public VcenterLcmNotificationsType Issues { get; set; }
    }
}
