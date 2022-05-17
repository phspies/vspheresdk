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
    public class CisTaggingCategoryUpdateTypeA 
    {
        /// <summary>
        /// Specification to update the category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_spec", Required = Required.AllowNull)]
        public CisTaggingCategoryUpdateSpecTypeA UpdateSpec { get; set; }
    }
}
