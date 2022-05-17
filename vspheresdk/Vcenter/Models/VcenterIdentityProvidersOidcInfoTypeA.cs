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
    public class VcenterIdentityProvidersOidcInfoTypeA 
    {
        /// <summary>
        /// Endpoint to retrieve the provider metadata
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "discovery_endpoint", Required = Required.AllowNull)]
        public string DiscoveryEndpoint { get; set; }
        /// <summary>
        /// The endpoint to use for terminating the user's session at the identity provider. This value is automatically derived
        /// from the metadata information provided by the OIDC discovery endpoint.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "logout_endpoint")]
        public string? LogoutEndpoint { get; set; }
        /// <summary>
        /// Authentication/authorization endpoint of the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_endpoint", Required = Required.AllowNull)]
        public string AuthEndpoint { get; set; }
        /// <summary>
        /// Token endpoint of the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_endpoint", Required = Required.AllowNull)]
        public string TokenEndpoint { get; set; }
        /// <summary>
        /// Endpoint to retrieve the provider public key for validation
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "public_key_uri", Required = Required.AllowNull)]
        public string PublicKeyUri { get; set; }
        /// <summary>
        /// Client identifier to connect to the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        public string ClientId { get; set; }
        /// <summary>
        /// The secret shared between the client and the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_secret", Required = Required.AllowNull)]
        public string ClientSecret { get; set; }
        /// <summary>
        /// The map used to transform an OAuth2 claim to a corresponding claim that vCenter Server understands. Currently only the
        /// key "perms" is supported. The key "perms" is used for mapping the "perms" claim of incoming JWT. The value is another
        /// map with an external group as the key and a vCenter Server group as value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "claim_map", Required = Required.AllowNull)]
        public IList<object> ClaimMap { get; set; }
        /// <summary>
        /// The identity provider namespace. It is used to validate the issuer in the acquired OAuth2 token
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer", Required = Required.AllowNull)]
        public string Issuer { get; set; }
        /// <summary>
        /// Authentication method used by the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authentication_method", Required = Required.AllowNull)]
        public VcenterIdentityProvidersOauth2AuthenticationMethodEnumTypeA AuthenticationMethod { get; set; }
        /// <summary>
        /// 
        /// key/value pairs that are to be appended to the authEndpoint request.
        /// 
        /// How to append to authEndpoint request:
        /// If the map is not empty, a "?" is added to the endpoint URL, and combination of each k and each string in the v is added
        /// with an "&" delimiter. Details:
        /// - If the value contains only one string, then the key is added with "k=v".
        /// - If the value is an empty list, then the key is added without a "=v".
        /// - If the value contains multiple strings, then the key is repeated in the query-string for each string in the value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_query_params", Required = Required.AllowNull)]
        public IList<object> AuthQueryParams { get; set; }
    }
}
