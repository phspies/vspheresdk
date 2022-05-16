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
    public class VstatsDataDataPointType 
    {
        /// <summary>
        /// Counter Id. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Counter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Counter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cid", Required = Required.AllowNull)]
        public string Cid { get; set; }
        /// <summary>
        /// CounterMetadata Id. Warning: This attribute is available as Technology Preview. These are early access APIs provided to
        /// test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.CounterMetadata. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vstats.model.CounterMetadata.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mid", Required = Required.AllowNull)]
        public string Mid { get; set; }
        /// <summary>
        /// Resource Id. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "rid", Required = Required.AllowNull)]
        public string Rid { get; set; }
        /// <summary>
        /// Timestamp for the data point. format: 64-bit integer. Warning: This attribute is available as Technology Preview. These
        /// are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ts", Required = Required.AllowNull)]
        public long Ts { get; set; }
        /// <summary>
        /// Stat value. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "val", Required = Required.AllowNull)]
        public double Val { get; set; }
    }
}
