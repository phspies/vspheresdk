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
    public class CisTaggingCategoryAddToUsedByType 
    {
        /// <summary>
        /// The name of the user to be added to the CategoryModel.used-by set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_by_entity", Required = Required.AllowNull)]
        public string UsedByEntity { get; set; }
    }
}
