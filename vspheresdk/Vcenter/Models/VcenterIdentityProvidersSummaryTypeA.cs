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
    public class VcenterIdentityProvidersSummaryTypeA 
    {
        /// <summary>
        /// The identifier of the provider
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.identity.Providers. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.identity.Providers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public string Provider { get; set; }
        /// <summary>
        /// The user friendly name for the provider
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The config type of the identity provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_tag", Required = Required.AllowNull)]
        public VcenterIdentityProvidersConfigTypeEnumA ConfigTag { get; set; }
        /// <summary>
        /// OAuth2 Summary
        /// This field is optional and it is only relevant when the value of Providers.Summary.config-tag is Oauth2.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth2")]
        public VcenterIdentityProvidersOauth2SummaryTypeA Oauth2 { get; set; }
        /// <summary>
        /// OIDC Summary
        /// This field is optional and it is only relevant when the value of Providers.Summary.config-tag is Oidc.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oidc")]
        public VcenterIdentityProvidersOidcSummaryTypeA Oidc { get; set; }
        /// <summary>
        /// Specifies whether the provider is the default provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_default", Required = Required.AllowNull)]
        public bool IsDefault { get; set; }
        /// <summary>
        /// Set of fully qualified domain names to trust when federating with this identity provider. Tokens from this identity
        /// provider will only be validated if the user belongs to one of these domains, and any domain-qualified groups in the
        /// tokens will be filtered to include only those groups that belong to one of these domains. If domainNames is an empty
        /// set, domain validation behavior at login with this identity provider will be as follows: the user's domain will be
        /// parsed from the User Principal Name (UPN) value that is found in the tokens returned by the identity provider. This
        /// domain will then be implicitly trusted and used to filter any groups that are also provided in the tokens.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
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
        /// 
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_query_params")]
        public IList<object> AuthQueryParams { get; set; }
    }
}
