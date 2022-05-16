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
    public class ContentLibraryItemUpdatesessionFileAddTypeA 
    {
        /// <summary>
        /// Specification for the file that needs to be added or updated. This includes whether the client wants to push the content
        /// or have the server pull it.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_spec", Required = Required.AllowNull)]
        public ContentLibraryItemUpdatesessionFileAddSpecTypeA FileSpec { get; set; }
    }
}
