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
    public class VstatsResourceAddressesFilterSpecType 
    {
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
        /// The ResourceAddresses.FilterSpec.page field is used to retrieve paged data for large result sets. It is an opaque paging
        /// token obtained from a prior call to the ResourceAddresses.list API. Warning: This attribute is available as Technology
        /// Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can
        /// change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in
        /// production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// when set a follow up page in a paged result set will be delivered.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "page")]
        public string? Page { get; set; }
    }
}
