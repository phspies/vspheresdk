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
    public class VcenterVmGuestCredentialsType 
    {
        /// <summary>
        /// If set, the operation will interact with the logged-in desktop session in the guest. This requires that the logged-on
        /// user matches the user specified by the Credentials. This is currently only supported for USERNAME_PASSWORD.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interactive_session", Required = Required.AllowNull)]
        public bool InteractiveSession { get; set; }
        /// <summary>
        /// The guest credentials type
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsTypeA Type { get; set; }
        /// <summary>
        /// For SAML_BEARER_TOKEN, this is the guest user to be associated with the credentials. For USERNAME_PASSWORD this is the
        /// guest username.
        /// If no user is specified for SAML_BEARER_TOKEN, a guest dependent mapping will decide what guest user account is applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name")]
        public string? UserName { get; set; }
        /// <summary>
        /// password
        /// This field is optional and it is only relevant when the value of Credentials.type is USERNAME_PASSWORD.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// SAML Bearer Token
        /// This field is optional and it is only relevant when the value of Credentials.type is SAML_BEARER_TOKEN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "saml_token")]
        public string? SamlToken { get; set; }
    }
}
