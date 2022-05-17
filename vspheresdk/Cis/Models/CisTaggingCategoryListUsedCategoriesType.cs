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
    public class CisTaggingCategoryListUsedCategoriesType 
    {
        /// <summary>
        /// The field on which the results will be filtered.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_by_entity", Required = Required.AllowNull)]
        public string UsedByEntity { get; set; }
    }
}
