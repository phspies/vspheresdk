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
    public class VcenterComputePoliciesTagUsageSummaryType 
    {
        /// <summary>
        /// Identifier of the policy that uses the tag indicated by {@link #tag}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public string Policy { get; set; }
        /// <summary>
        /// Identifier of the tag type used by the policy indicated by {@link #policy}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_type", Required = Required.AllowNull)]
        public string TagType { get; set; }
        /// <summary>
        /// Identifier of the tag used by the policy indicated by {@link #policy}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag", Required = Required.AllowNull)]
        public string Tag { get; set; }
        /// <summary>
        /// Name of the tag used by the policy indicated by {@link #policy}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_name", Required = Required.AllowNull)]
        public string TagName { get; set; }
        /// <summary>
        /// Name of the category that has {@link #tag}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category_name", Required = Required.AllowNull)]
        public string CategoryName { get; set; }
    }
}
