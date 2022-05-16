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
    public class VcenterComputePoliciesSummaryType 
    {
        /// <summary>
        /// Identifier of the policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public string Policy { get; set; }
        /// <summary>
        /// Name of the policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Identifier of the capability this policy is based on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capability", Required = Required.AllowNull)]
        public string Capability { get; set; }
    }
}
