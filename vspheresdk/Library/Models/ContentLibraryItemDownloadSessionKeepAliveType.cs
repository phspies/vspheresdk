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
    public class ContentLibraryItemDownloadSessionKeepAliveType 
    {
        /// <summary>
        /// Optional update to the progress property of the session. If specified, the new progress should be greater then the
        /// current progress. See {@link DownloadSessionModel#clientProgress}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public long? Progress { get; set; }
    }
}
