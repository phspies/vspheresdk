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
    public class CisTaggingCategoryCreateTypeA 
    {
        /// <summary>
        /// Specification for the new category to be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "create_spec", Required = Required.AllowNull)]
        public CisTaggingCategoryCreateSpecTypeA CreateSpec { get; set; }
    }
}
