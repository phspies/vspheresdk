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
    public class CisTaggingCategoryUpdateSpecType 
    {
        /// <summary>
        /// The display name of the category.
        /// If unset the name will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The description of the category.
        /// If unset the description will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The associated cardinality (Cardinality) of the category.
        /// If unset the cardinality will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cardinality")]
        public CisTaggingCategoryModelCardinalityType Cardinality { get; set; }
        /// <summary>
        /// Object types to which this category's tags can be attached.
        /// The set of associable types cannot be updated incrementally. For example, if Category.UpdateSpec.associable-types
        /// originally contains {A,B,C} and you want to add D, then you need to pass {A,B,C,D} in your update specification. You
        /// also cannot remove any item from this set. For example, if you have {A,B,C}, then you cannot remove say {A} from it.
        /// Similarly, if you start with an empty set, then that implies that you can tag any object and hence you cannot later pass
        /// say {A}, because that would be restricting the type of objects you want to tag. Thus, associable types can only grow and
        /// not shrink.
        /// 
        /// If unset the associable types will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "associable_types")]
        public IList<string> AssociableTypes { get; set; }
    }
}
