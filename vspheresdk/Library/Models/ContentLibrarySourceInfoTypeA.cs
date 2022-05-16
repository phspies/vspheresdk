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
    public class ContentLibrarySourceInfoTypeA 
    {
        /// <summary>
        /// Identifier of the published library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_library")]
        public string? SourceLibrary { get; set; }
        /// <summary>
        /// Identifier of the subscription associated with the subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription")]
        public string? Subscription { get; set; }
    }
}
