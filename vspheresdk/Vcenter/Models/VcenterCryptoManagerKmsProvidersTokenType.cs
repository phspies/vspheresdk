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
    public class VcenterCryptoManagerKmsProvidersTokenType 
    {
        /// <summary>
        /// A one-time, short-lived token required in "Authorization" field of the HTTP header of the request to the url.
        /// After the token expires, any attempt to download the configuration with said token will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token", Required = Required.AllowNull)]
        public string Token { get; set; }
        /// <summary>
        /// Expiry time of the token
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiry", Required = Required.AllowNull)]
        public DateTime Expiry { get; set; }
    }
}
