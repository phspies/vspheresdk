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
    public class ContentLocalLibraryUpdateTypeA 
    {
        /// <summary>
        /// Specification of the new property values to set on the local library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_spec", Required = Required.AllowNull)]
        public ContentLibraryModelTypeA UpdateSpec { get; set; }
    }
}
