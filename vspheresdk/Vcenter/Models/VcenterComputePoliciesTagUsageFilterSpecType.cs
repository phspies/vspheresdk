using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterComputePoliciesTagUsageFilterSpecType 
    {
        /// <summary>
        /// Identifiers that compute policies must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policies")]
        public IList<string> Policies { get; set; }
        /// <summary>
        /// Identifiers that tags must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }
        /// <summary>
        /// Identifiers that tag types must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_types")]
        public IList<string> TagTypes { get; set; }
    }
}
