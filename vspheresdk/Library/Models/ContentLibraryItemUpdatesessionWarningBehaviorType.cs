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
    public class ContentLibraryItemUpdatesessionWarningBehaviorType 
    {
        /// <summary>
        /// The warning type which may be raised during the update session.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public ContentLibraryItemUpdatesessionWarningTypeEnum Type { get; set; }
        /// <summary>
        /// Indicates if this warning will be ignored during session complete operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignored", Required = Required.AllowNull)]
        public bool Ignored { get; set; }
    }
}
