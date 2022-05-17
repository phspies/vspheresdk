using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsDefaultsClustersPoliciesApplyEffectiveFailureActionType 
    {
        /// <summary>
        /// What action ({@enum.values Action}) is to be taken if entering maintenance mode fails on a single host within the
        /// cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public EsxSettingsDefaultsClustersPoliciesApplyEffectiveFailureActionActionType Action { get; set; }
        /// <summary>
        /// Time to wait to retry the failed operation in seconds.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retry_delay")]
        public long? RetryDelay { get; set; }
        /// <summary>
        /// Number of times to retry the failed operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retry_count")]
        public long? RetryCount { get; set; }
    }
}
