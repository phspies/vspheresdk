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
    public class CisTaggingCategoryCreateSpecTypeA 
    {
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
        public CisTaggingCategoryModelCardinalityTypeA Cardinality { get; set; }
        /// <summary>
        /// Object types to which this category's tags can be attached.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "associable_types", Required = Required.AllowNull)]
        public IList<string> AssociableTypes { get; set; }
        /// <summary>
        /// If unset an identifier will be generated by the server
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.tagging.Category. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: cis.tagging.Category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category_id")]
        public string? CategoryId { get; set; }
    }
}
