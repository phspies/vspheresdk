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
    public class VcenterTokenserviceTokenExchangeInfoType 
    {
        /// <summary>
        /// The security token issued by the server in response to the token exchange request. Token is base64-encoded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_token", Required = Required.AllowNull)]
        public string AccessToken { get; set; }
        /// <summary>
        /// An identifier, that indicates the type of the security token in the {@link Info#access_token} parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issued_token_type", Required = Required.AllowNull)]
        public string IssuedTokenType { get; set; }
        /// <summary>
        /// A case-insensitive value specifying the method of using the access token issued.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_type", Required = Required.AllowNull)]
        public string TokenType { get; set; }
        /// <summary>
        /// The validity lifetime, in seconds, of the token issued by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public long? ExpiresIn { get; set; }
        /// <summary>
        /// Scope of the issued security token.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// A refresh token can be issued in cases where the client of the token exchange needs the ability to access a resource
        /// even when the original credential is no longer valid.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string? RefreshToken { get; set; }
    }
}
