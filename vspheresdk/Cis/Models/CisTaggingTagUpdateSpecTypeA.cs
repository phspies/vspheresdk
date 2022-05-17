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
    public class CisTaggingTagUpdateSpecTypeA 
    {
        /// <summary>
        /// The display name of the tag.
        /// If unset the name will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The description of the tag.
        /// If unset the description will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
