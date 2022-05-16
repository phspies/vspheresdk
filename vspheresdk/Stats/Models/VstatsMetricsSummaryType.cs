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
    public class VstatsMetricsSummaryType 
    {
        /// <summary>
        /// Metric name. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Metric. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Metric.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric", Required = Required.AllowNull)]
        public string Metric { get; set; }
    }
}
