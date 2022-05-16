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
    public class VstatsRsrcIdType 
    {
        /// <summary>
        /// Key relates to the corresponding ResourceIdDefinition of the related resource address schema. Warning: This attribute is
        /// available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the
        /// feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends
        /// against using them in production environments. Some Technology Preview APIs might only be applicable to specific
        /// environments.
        /// When this field is unset, type field will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// Type of the resource identified by the Resource Id. Warning: This attribute is available as Technology Preview. These
        /// are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When this field is unset, in current version the api will throw InvalidArgument error. To be made optional in future.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// The id value binding the related resource id definition. Warning: This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id_value", Required = Required.AllowNull)]
        public string IdValue { get; set; }
        /// <summary>
        /// Predicate to use to match resource Ids. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// When this field is unset, default predicate is EQUAL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "predicate")]
        public VstatsQueryPredicateType Predicate { get; set; }
        /// <summary>
        /// An optional designation of the scheme. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// When this field is unset, default scheme is moid (ManagedObject Identifier).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public string? Scheme { get; set; }
    }
}
