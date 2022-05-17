using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiMetadataAuthenticationAuthenticationInfoType 
    {
        /// <summary>
        /// The type of the authentication scheme.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheme_type", Required = Required.AllowNull)]
        public VapiMetadataAuthenticationAuthenticationInfoSchemeType SchemeType { get; set; }
        /// <summary>
        /// In a session aware authentication scheme, a session manager is required that supports {@code create}, {@code delete} and
        /// {@code keepAlive} {@term operations}. The fully qualified {@term service} name of the session manager is provided in
        /// {@link AuthenticationInfo#sessionManager} {@term field}. This {@term service} is responsible for handling sessions.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "session_manager")]
        public string? SessionManager { get; set; }
        /// <summary>
        /// String identifier of the authentication scheme. <p> Following are the supported authentication schemes by the
        /// infrastructure: <ul> <li>The identifier {@code vapi.std.security.saml_hok_token} for SAML holder of key token based
        /// authentication mechanism. </li> <li>The identifier {@code vapi.std.security.bearer_token} for SAML bearer token based
        /// authentication mechanism. </li> <li>The identifier {@code vapi.std.security.session_id} for session based authentication
        /// mechanism. </li> <li>The identifier {@code vapi.std.security.user_pass} for username and password based authentication
        /// mechanism. </li> </ul>
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scheme", Required = Required.AllowNull)]
        public string Scheme { get; set; }
    }
}
