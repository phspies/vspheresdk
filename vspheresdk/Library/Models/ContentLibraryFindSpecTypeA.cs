using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLibraryFindSpecTypeA 
    {
        /// <summary>
        /// Name of the library to search. The name is case-insensitive. See {@link LibraryModel#name}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Library type to search. See {@link LibraryModel#type}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ContentLibraryModelLibraryTypeA Type { get; set; }
    }
}
