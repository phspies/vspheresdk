using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxHclReportsTokenType 
    {
        /// <summary>
        /// A one-time, short-lived token required in the HTTP header of the request to the url. This token needs to be passed in as
        /// a header with the name "session-id".
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
