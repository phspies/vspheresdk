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
    public class VstatsAcqSpecsCounterSpecType 
    {
        /// <summary>
        /// Counter and optional meatadata identifier. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// When unset the AcqSpecs.CounterSpec.set-id field will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cid_mid")]
        public VstatsCidMidType CidMid { get; set; }
        /// <summary>
        /// Counter set identifier. Warning: This attribute is available as Technology Preview. These are early access APIs provided
        /// to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When unset the AcqSpecs.CounterSpec.cid-mid field will be used.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.CounterSet. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: vstats.model.CounterSet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "set_id")]
        public string? SetId { get; set; }
    }
}
