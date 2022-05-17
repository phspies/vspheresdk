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
    public class CisTaggingCategoryModelType 
    {
        /// <summary>
        /// The unique identifier of the category.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.tagging.Category. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: cis.tagging.Category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The display name of the category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The description of the category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// The associated cardinality (Cardinality) of the category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cardinality", Required = Required.AllowNull)]
        public CisTaggingCategoryModelCardinalityEnumType Cardinality { get; set; }
        /// <summary>
        /// The types of objects that the tags in this category can be attached to. If the set is empty, then tags can be attached
        /// to all types of objects. This field works only for objects that reside in Inventory Service (IS). For non IS objects,
        /// this check is not performed today and hence a tag can be attached to any non IS object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "associable_types", Required = Required.AllowNull)]
        public IList<string> AssociableTypes { get; set; }
        /// <summary>
        /// The set of users that can use this category. To add users to this, you need to have the edit privilege on the category.
        /// Similarly, to unsubscribe from this category, you need the edit privilege on the category. You should not modify other
        /// users subscription from this set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_by", Required = Required.AllowNull)]
        public IList<string> UsedBy { get; set; }
    }
}
