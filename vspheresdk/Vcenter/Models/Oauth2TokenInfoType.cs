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
    public class Oauth2TokenInfoType 
    {
        /// <summary>
        /// The access token issued by the authorization server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_token", Required = Required.AllowNull)]
        public string AccessToken { get; set; }
        /// <summary>
        /// A case-insensitive value specifying the method of using the access token issued.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_type", Required = Required.AllowNull)]
        public string TokenType { get; set; }
        /// <summary>
        /// The validity lifetime, in seconds, of the token issued by the server.
        /// unset if not applicable for issued token.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public long? ExpiresIn { get; set; }
        /// <summary>
        /// Scope of the issued access token. The value of the scope parameter is expressed as a list of space- delimited,
        /// case-sensitive strings. The strings are defined by the authorization server. If the value contains multiple
        /// space-delimited strings, their order does not matter, and each string adds an additional access range to the requested
        /// scope.
        /// unset if the scope of the issued security token is identical to the scope requested by the client.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// The refresh token, which can be used to obtain new access tokens.
        /// unset if not applicable to the specific request.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string? RefreshToken { get; set; }
        /// <summary>
        /// An identifier which indicates the type of the access token in the TokenInfo.access-token field.
        /// unset if not the result of a token-exchange invocation; otherwise, required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issued_token_type")]
        public string? IssuedTokenType { get; set; }
    }
}
