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
    public class ContentLibraryItemUpdateTypeA 
    {
        /// <summary>
        /// Specification of the properties to set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_spec", Required = Required.AllowNull)]
        public ContentLibraryItemModelTypeA UpdateSpec { get; set; }
    }
}
