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
    public class VcenterTaggingAssociationsSummaryType 
    {
        /// <summary>
        /// The identifier of a tag.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.tagging.Tag. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: cis.tagging.Tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag", Required = Required.AllowNull)]
        public string Tag { get; set; }
        /// <summary>
        /// The identifier of an associated object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "object", Required = Required.AllowNull)]
        public VapiStdDynamicIdtype ObjectProperty { get; set; }
    }
}
