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
    public class VstatsCidMidType 
    {
        /// <summary>
        /// Counter Id. CID is a string with rather strong semantic consistency across deployments and versions. If two CIDs are
        /// identical it implies the corresponding counters are the same. Warning: This attribute is available as Technology
        /// Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can
        /// change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in
        /// production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.Counter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.Counter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cid", Required = Required.AllowNull)]
        public string Cid { get; set; }
        /// <summary>
        /// MID is a 64-bit integer with strong consistency. Given a particular CID=cid, if two MIDs are the same, then the
        /// corresponding counter-metadata objects are same. Warning: This attribute is available as Technology Preview. These are
        /// early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// When this field is unset vStats will use default for the counter metadata as obtained from the provider.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.CounterMetadata. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vstats.model.CounterMetadata.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mid")]
        public string? Mid { get; set; }
    }
}
