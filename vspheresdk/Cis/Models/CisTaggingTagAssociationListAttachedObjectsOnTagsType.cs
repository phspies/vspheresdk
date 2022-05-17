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
    public class CisTaggingTagAssociationListAttachedObjectsOnTagsType 
    {
        /// <summary>
        /// The identifiers of the input tags.
        /// The parameter must contain identifiers for the resource type: cis.tagging.Tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag_ids", Required = Required.AllowNull)]
        public IList<string> TagIds { get; set; }
    }
}
