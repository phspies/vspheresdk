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
    public class VcenterCryptoManagerKmsProvidersLocationType 
    {
        /// <summary>
        /// Provider configuration download URL
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// Information about the token required in the HTTP GET request to download the provider configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "download_token", Required = Required.AllowNull)]
        public VcenterCryptoManagerKmsProvidersTokenType DownloadToken { get; set; }
    }
}
