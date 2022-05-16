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
    public class VcenterAuthenticationTokenIssueType 
    {
        /// <summary>
        /// The value of urn:ietf:params:oauth:grant-type:token-exchange indicates that a token exchange is being performed.
        /// When clients pass a value of this structure as a parameter, the field must be one of
        /// urn:ietf:params:oauth:grant-type:token-exchange. When operations return a value of this structure as a result, the field
        /// will be one of urn:ietf:params:oauth:grant-type:token-exchange.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "grant_type", Required = Required.AllowNull)]
        public string GrantType { get; set; }
        /// <summary>
        /// Indicates the location of the target service or resource where the client intends to use the requested security token.
        /// If unset, it is inferred from other arguments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string? Resource { get; set; }
        /// <summary>
        /// The logical name of the target service where the client intends to use the requested security token. This serves a
        /// purpose similar to the Token.IssueSpec.resource field, but with the client providing a logical name rather than a
        /// location.
        /// If unset, it is inferred from other arguments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "audience")]
        public string? Audience { get; set; }
        /// <summary>
        /// A list of space-delimited, case-sensitive strings, that allow the client to specify the desired scope of the requested
        /// security token in the context of the service or resource where the token will be used.
        /// If unset, it is inferred from other arguments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// An identifier for the type of the requested security token. If the requested type is unspecified, the issued token type
        /// is at the discretion of the server and may be dictated by knowledge of the requirements of the service or resource
        /// indicated by the Token.IssueSpec.resource or Token.IssueSpec.audience field.
        /// If unset, it is inferred from other arguments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "requested_token_type")]
        public string? RequestedTokenType { get; set; }
        /// <summary>
        /// A security token that represents the identity of the party on behalf of whom exchange is being made. Typically, the
        /// subject of this token will be the subject of the security token issued. Token is base64-encoded.
        /// The field is required when the value of the Token.IssueSpec.grant-type field is
        /// urn:ietf:params:oauth:grant-type:token-exchange.
        /// 
        /// This field is currently required. In the future, the structure may support grant-types other than
        /// urn:ietf:params:oauth:grant-type:token-exchange for which the value may be unset.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_token")]
        public string? SubjectToken { get; set; }
        /// <summary>
        /// An identifier, that indicates the type of the security token in the Token.IssueSpec.subject-token field.
        /// The field is required when the value of the Token.IssueSpec.grant-type field is
        /// urn:ietf:params:oauth:grant-type:token-exchange.
        /// 
        /// This field is currently required. In the future, the structure may support grant-types other than
        /// urn:ietf:params:oauth:grant-type:token-exchange for which the value may be unset.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_token_type")]
        public string? SubjectTokenType { get; set; }
        /// <summary>
        /// A security token that represents the identity of the acting party. Typically, this will be the party that is authorized
        /// to use the requested security token and act on behalf of the subject.
        /// unset if not needed for the specific case of exchange.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "actor_token")]
        public string? ActorToken { get; set; }
        /// <summary>
        /// An identifier, that indicates the type of the security token in the Token.IssueSpec.actor-token field.
        /// unset if Token.IssueSpec.actor-token field is not present.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "actor_token_type")]
        public string? ActorTokenType { get; set; }
    }
}
