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
    public class VcenterTokenserviceTokenExchangeExchangeSpecType 
    {
        /// <summary>
        /// The value of {@link TokenExchange#TOKEN_EXCHANGE_GRANT} indicates that a token exchange is being performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "grant_type", Required = Required.AllowNull)]
        public string GrantType { get; set; }
        /// <summary>
        /// Indicates the location of the target service or resource where the client intends to use the requested security token.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string? Resource { get; set; }
        /// <summary>
        /// The logical name of the target service where the client intends to use the requested security token. This serves a
        /// purpose similar to the {@link ExchangeSpec#resource} parameter, but with the client providing a logical name rather than
        /// a location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        public string? Audience { get; set; }
        /// <summary>
        /// A list of space-delimited, case-sensitive strings, that allow the client to specify the desired scope of the requested
        /// security token in the context of the service or resource where the token will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// An identifier for the type of the requested security token. If the requested type is unspecified, the issued token type
        /// is at the discretion of the server and may be dictated by knowledge of the requirements of the service or resource
        /// indicated by the {@link ExchangeSpec#resource} or {@link ExchangeSpec#audience} parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "requested_token_type")]
        public string? RequestedTokenType { get; set; }
        /// <summary>
        /// A security token that represents the identity of the party on behalf of whom exchange is being made. Typically, the
        /// subject of this token will be the subject of the security token issued. Token is base64-encoded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_token", Required = Required.AllowNull)]
        public string SubjectToken { get; set; }
        /// <summary>
        /// An identifier, that indicates the type of the security token in the {@link ExchangeSpec#subject_token} parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_token_type", Required = Required.AllowNull)]
        public string SubjectTokenType { get; set; }
        /// <summary>
        /// A security token that represents the identity of the acting party. Typically, this will be the party that is authorized
        /// to use the requested security token and act on behalf of the subject.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "actor_token")]
        public string? ActorToken { get; set; }
        /// <summary>
        /// An identifier, that indicates the type of the security token in the {@link ExchangeSpec#actor_token} parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "actor_token_type")]
        public string? ActorTokenType { get; set; }
    }
}
