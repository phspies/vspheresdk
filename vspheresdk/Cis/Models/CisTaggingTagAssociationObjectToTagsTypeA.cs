using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Models
{
    public class CisTaggingTagAssociationObjectToTagsTypeA 
    {
        /// <summary>
        /// The identifier of the object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "object_id", Required = Required.AllowNull)]
        public VapiStdDynamicIdtypeA ObjectId { get; set; }
        /// <summary>
        /// The identifiers of the related tags.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// cis.tagging.Tag. When operations return a value of this structure as a result, the field will contain identifiers for
        /// the resource type: cis.tagging.Tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_ids", Required = Required.AllowNull)]
        public IList<string> TagIds { get; set; }
    }
}
