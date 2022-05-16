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
    public class ContentSubscribedLibraryProbeResultType 
    {
        /// <summary>
        /// The status of probe result. This will be one of {@enum.values Status}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ContentSubscribedLibraryProbeResultStatusType Status { get; set; }
        /// <summary>
        /// The SSL thumbprint for the remote endpoint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// If the probe result is in an error status, this {@term field} will contain the detailed error messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_messages", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> ErrorMessages { get; set; }
    }
}
