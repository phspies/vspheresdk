using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class Oauth2ErrorsInvalidScopeType 
    {
        /// <summary>
        /// Discriminator field to help API consumers identify the structure type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error", Required = Required.AllowNull)]
        public Oauth2ErrorsErrorType Error { get; set; }
        /// <summary>
        /// Human-readable ASCII text providing additional information, used to assist the client developer in understanding the
        /// error that occurred. Values for the "error_description" parameter MUST NOT include characters outside the set %x20-21 /
        /// %x23-5B / %x5D-7E.
        /// if no additional information is available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_description")]
        public string? ErrorDescription { get; set; }
        /// <summary>
        /// A URI identifying a human-readable web page with information about the error, used to provide the client developer with
        /// additional information about the error.
        /// if no such web-page is available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_uri")]
        public string? ErrorUri { get; set; }
    }
}
