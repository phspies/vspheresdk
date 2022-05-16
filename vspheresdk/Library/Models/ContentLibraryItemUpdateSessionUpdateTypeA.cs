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
    public class ContentLibraryItemUpdateSessionUpdateTypeA 
    {
        /// <summary>
        /// Specification for the new property values to be set on the update session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_spec", Required = Required.AllowNull)]
        public ContentLibraryItemUpdateSessionModelTypeA UpdateSpec { get; set; }
    }
}
