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
    public class VcenterIdentityProvidersOauth2UpdateSpecType 
    {
        /// <summary>
        /// Authentication/authorization endpoint of the provider
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_endpoint")]
        public string? AuthEndpoint { get; set; }
        /// <summary>
        /// Token endpoint of the provider.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_endpoint")]
        public string? TokenEndpoint { get; set; }
        /// <summary>
        /// Endpoint to retrieve the provider public key for validation
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "public_key_uri")]
        public string? PublicKeyUri { get; set; }
        /// <summary>
        /// Client identifier to connect to the provider
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_id")]
        public string? ClientId { get; set; }
        /// <summary>
        /// Shared secret between identity provider and client
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        public string? ClientSecret { get; set; }
        /// <summary>
        /// The map used to transform an OAuth2 claim to a corresponding claim that vCenter Server understands. Currently only the
        /// key "perms" is supported. The key "perms" is used for mapping the "perms" claim of incoming JWT. The value is another
        /// map with an external group as the key and a vCenter Server group as value.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "claim_map")]
        public object ClaimMap { get; set; }
        /// <summary>
        /// The identity provider namespace. It is used to validate the issuer in the acquired OAuth2 token
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public string? Issuer { get; set; }
        /// <summary>
        /// Authentication method used by the provider
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authentication_method")]
        public VcenterIdentityProvidersOauth2AuthenticationMethodType AuthenticationMethod { get; set; }
        /// <summary>
        /// key/value pairs that are to be appended to the authEndpoint request. How to append to authEndpoint request: If the map
        /// is not empty, a "?" is added to the endpoint URL, and combination of each k and each string in the v is added with an
        /// "&" delimiter. Details: If the value contains only one string, then the key is added with "k=v". If the value is an
        /// empty list, then the key is added without a "=v". If the value contains multiple strings, then the key is repeated in
        /// the query-string for each string in the value. If the map is empty, deletes all params.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_query_params")]
        public object AuthQueryParams { get; set; }
    }
}
