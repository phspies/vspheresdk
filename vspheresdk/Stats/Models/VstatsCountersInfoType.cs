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
    public class VstatsCountersInfoType 
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
        /// A metric is typically human-legible ASCII/English name of a measurable aspect, for example "length" and "temperature".
        /// It is not internationalizable. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Metric. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Metric.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric", Required = Required.AllowNull)]
        public string Metric { get; set; }
        /// <summary>
        /// Describes formally how to address (or identify) the resources the counter could be bound to (or instantiated for).
        /// Warning: This attribute is available as Technology Preview. These are early access APIs provided to test, automate and
        /// provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards
        /// compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be
        /// applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.RsrcAddrSchema. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vstats.model.RsrcAddrSchema.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_address_schema", Required = Required.AllowNull)]
        public string ResourceAddressSchema { get; set; }
    }
}
