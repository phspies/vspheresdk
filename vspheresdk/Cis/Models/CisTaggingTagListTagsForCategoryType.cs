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
    public class CisTaggingTagListTagsForCategoryType 
    {
        /// <summary>
        /// The identifier of the input category.
        /// The parameter must be an identifier for the resource type: cis.tagging.Category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category_id", Required = Required.AllowNull)]
        public string CategoryId { get; set; }
    }
}
