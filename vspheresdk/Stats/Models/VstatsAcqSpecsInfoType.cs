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
    public class VstatsAcqSpecsInfoType 
    {
        /// <summary>
        /// Acquisition specification identifier. Warning: This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.AcqSpec. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.AcqSpec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
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
        /// When this field is unset, default interval is 10 seconds.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public long? Interval { get; set; }
        /// <summary>
        /// Expiration time for this acquisition specification represented as Unix UTC number of seconds (since epoch). Warning:
        /// This attribute is available as Technology Preview. These are early access APIs provided to test, automate and provide
        /// feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and
        /// recommends against using them in production environments. Some Technology Preview APIs might only be applicable to
        /// specific environments.
        /// When this field is unset or 0, default expiration duration is 100 minutes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiration")]
        public long? Expiration { get; set; }
        /// <summary>
        /// Consumer provided text about this Acquisition Specification. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memo_", Required = Required.AllowNull)]
        public string Memo { get; set; }
        /// <summary>
        /// Acquisition Specification status. Warning: This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VstatsAcqSpecsStatusType Status { get; set; }
    }
}
