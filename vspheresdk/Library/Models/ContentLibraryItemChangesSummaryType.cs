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
    public class ContentLibraryItemChangesSummaryType 
    {
        /// <summary>
        /// The version of the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// The date and time when the item content was changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time", Required = Required.AllowNull)]
        public DateTime Time { get; set; }
        /// <summary>
        /// The user who made the content change.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// The short message describing the content change. The message is truncated to the first 80 characters or first
        /// non-leading newline character, whichever length is shorter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "short_message")]
        public string? ShortMessage { get; set; }
    }
}
