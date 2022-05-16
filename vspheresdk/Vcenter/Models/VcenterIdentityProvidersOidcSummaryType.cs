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
    public class VcenterIdentityProvidersOidcSummaryType 
    {
        /// <summary>
        /// Endpoint to retrieve the provider metadata
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "discovery_endpoint")]
        public string? DiscoveryEndpoint { get; set; }
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
        /// Client identifier to connect to the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        public string ClientId { get; set; }
        /// <summary>
        /// The authentication data used as part of request header to acquire or refresh an OAuth2 token. The data format depends on
        /// the authentication method used. Example of basic authentication format: Authorization: Basic [base64Encode(clientId +
        /// ":" + secret)]
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authentication_header", Required = Required.AllowNull)]
        public string AuthenticationHeader { get; set; }
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
        public object AuthQueryParams { get; set; }
    }
}
