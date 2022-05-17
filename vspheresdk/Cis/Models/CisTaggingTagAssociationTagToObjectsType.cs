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
    public class CisTaggingTagAssociationTagToObjectsType 
    {
        /// <summary>
        /// The identifier of the tag.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.tagging.Tag. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: cis.tagging.Tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_id", Required = Required.AllowNull)]
        public string TagId { get; set; }
        /// <summary>
        /// The identifiers of the related objects.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "object_ids", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdDynamicIdtype> ObjectIds { get; set; }
    }
}
