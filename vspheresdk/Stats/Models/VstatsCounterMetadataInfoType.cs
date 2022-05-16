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
    public class VstatsCounterMetadataInfoType 
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
        /// Metadata Id. Warning: This attribute is available as Technology Preview. These are early access APIs provided to test,
        /// automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
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
        /// Counter Edition status. Warning: This attribute is available as Technology Preview. These are early access APIs provided
        /// to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VstatsCounterMetadataCounterEditionStatusType Status { get; set; }
        /// <summary>
        /// Numeric properties of the sampled data. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VstatsCounterMetadataSampleType Type { get; set; }
        /// <summary>
        /// The units of the measurement. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "units", Required = Required.AllowNull)]
        public VstatsCounterMetadataMetricUnitsType Units { get; set; }
        /// <summary>
        /// Additional multiplier factors to be used with units. Warning: This attribute is available as Technology Preview. These
        /// are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When unset default of ONE is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scale")]
        public VstatsCounterMetadataUnitsFactorType Scale { get; set; }
        /// <summary>
        /// Human legible localizable text about the counter. Warning: This attribute is available as Technology Preview. These are
        /// early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// This field is unset in the current version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_info")]
        public VstatsUserInfoType UserInfo { get; set; }
        /// <summary>
        /// ID of the respective provider. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// This field is unset in the current version.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Provider. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pid")]
        public string? Pid { get; set; }
    }
}
