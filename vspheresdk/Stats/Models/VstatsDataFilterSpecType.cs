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
    public class VstatsDataFilterSpecType 
    {
        /// <summary>
        /// Start of a time window (included), timestamp in seconds UTC. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When unset the result will not be limited by start time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public long? Start { get; set; }
        /// <summary>
        /// End of a time window (excluded), timestamp in seconds UTC. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When unset the result will not be limited by end time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public long? End { get; set; }
        /// <summary>
        /// Counter ID. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// When unset the result will not be filtered by counter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Counter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Counter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cid")]
        public string? Cid { get; set; }
        /// <summary>
        /// Metric name. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// When unset the result will not be filtered by metric name.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Metric. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Metric.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metric")]
        public string? Metric { get; set; }
        /// <summary>
        /// List of Resource types. Warning: This attribute is available as Technology Preview. These are early access APIs provided
        /// to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When unset the result will not be filtered by resource types.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vstats.model.RsrcType. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: vstats.model.RsrcType.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public IList<string> Types { get; set; }
        /// <summary>
        /// Resources to include in the query. Each resource is specified through a composite string that follows the following
        /// format.
        /// type.<resource type>[.<scheme>]=<resource id>
        /// 
        /// resource type specifies the type of resource for example VM, VCPU etc.
        /// 
        /// scheme is an optional element to disambiguate the resource as needed for example to differentiate managed object id from
        /// uuid.
        /// 
        /// resource id is the unique resource identifier value for example: vm-41
        /// 
        /// Example values include: type.VM=vm-41, type.VCPU=1, type.VM.moid=vm-41
        /// . Warning: This attribute is available as Technology Preview. These are early access APIs provided to test, automate and
        /// provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards
        /// compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be
        /// applicable to specific environments.
        /// When left unset the result will not be filtered for specific resources.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<string> Resources { get; set; }
        /// <summary>
        /// Directs the server to order the returned data. Passing a value of DEFAULT will apply default ordering of the results
        /// that makes them easier for consumption. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// When this parameter is unset the server will not order the result, save computational time and therefore the API will
        /// operate faster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public string? Order { get; set; }
        /// <summary>
        /// Used to retrieve paged data for larger result sets. The value of this token is generated by server and returned as next
        /// field in the result of Data.query-data-points operations. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When unset the first page of results will be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public string? Page { get; set; }
    }
}
