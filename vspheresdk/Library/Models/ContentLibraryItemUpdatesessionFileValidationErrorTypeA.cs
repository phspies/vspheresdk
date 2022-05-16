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
    public class ContentLibraryItemUpdatesessionFileValidationErrorTypeA 
    {
        /// <summary>
        /// The name of the file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// A message indicating why the file was considered invalid.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_message", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageTypeA ErrorMessage { get; set; }
    }
}
