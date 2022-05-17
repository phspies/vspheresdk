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
    public class CisTaggingTagModelType 
    {
        /// <summary>
        /// The unique identifier of the tag.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.tagging.Tag. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: cis.tagging.Tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The identifier of the parent category in which this tag will be created.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.tagging.Category. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: cis.tagging.Category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category_id", Required = Required.AllowNull)]
        public string CategoryId { get; set; }
        /// <summary>
        /// The display name of the tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The description of the tag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// The set of users that can use this tag. To add users to this, you need to have the edit privilege on the tag. Similarly,
        /// to unsubscribe from this tag, you need the edit privilege on the tag. You should not modify other users subscription
        /// from this set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_by", Required = Required.AllowNull)]
        public IList<string> UsedBy { get; set; }
    }
}
