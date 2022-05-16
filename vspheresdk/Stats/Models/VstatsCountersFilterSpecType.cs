using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Stats.Models.Enums;

namespace vspheresdk.Stats.Models
{
    public class VstatsCountersFilterSpecType 
    {
        /// <summary>
        /// Counter identifier that will be listed. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// If unset counter filter will not be applied.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Counter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Counter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cid")]
        public string? Cid { get; set; }
        /// <summary>
        /// Resource type filter. Warning: This attribute is available as Technology Preview. These are early access APIs provided
        /// to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// If unset resource type filter will not be applied.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vstats.model.RsrcType. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: vstats.model.RsrcType.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public IList<string> Types { get; set; }
        /// <summary>
        /// Metric for which counters will be listed. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// If unset metric filter will not be applied.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Metric. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Metric.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric")]
        public string? Metric { get; set; }
    }
}
