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
    public class VstatsAcqSpecsCreateSpecType 
    {
        /// <summary>
        /// Designates the counter(s) to be sampled. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "counters", Required = Required.AllowNull)]
        public VstatsAcqSpecsCounterSpecType Counters { get; set; }
        /// <summary>
        /// A set of resource identifiers representing a single resource to be monitored. Warning: This attribute is available as
        /// Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since
        /// this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them
        /// in production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources", Required = Required.AllowNull)]
        public Dictionary<string,VstatsRsrcIdType> Resources { get; set; }
        /// <summary>
        /// Desired sampling rate in seconds. Warning: This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// If unset default of 10s will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public long? Interval { get; set; }
        /// <summary>
        /// Expiration time for this acquisition specification in Unix UTC number of seconds (since epoch). Warning: This attribute
        /// is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the
        /// feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends
        /// against using them in production environments. Some Technology Preview APIs might only be applicable to specific
        /// environments.
        /// When this field is unset or 0, default expiration duration is 100 minutes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public long? Expiration { get; set; }
        /// <summary>
        /// Consumer provided text about this acquisition specification. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// If unset default empty string will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memo_")]
        public string? Memo { get; set; }
    }
}
