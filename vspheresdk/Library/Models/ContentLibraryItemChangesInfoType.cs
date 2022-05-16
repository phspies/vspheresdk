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
    public class ContentLibraryItemChangesInfoType 
    {
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
        /// The full message describing the content change.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
    }
}
