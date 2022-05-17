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
    public class VcenterIdentityProvidersInfoTypeA 
    {
        /// <summary>
        /// The user friendly name for the provider
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The set of orgIds as part of SDDC creation which provides the basis for tenancy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "org_ids", Required = Required.AllowNull)]
        public IList<string> OrgIds { get; set; }
        /// <summary>
        /// The config type of the identity provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_tag", Required = Required.AllowNull)]
        public VcenterIdentityProvidersConfigTypeEnumA ConfigTag { get; set; }
        /// <summary>
        /// OAuth2 Info
        /// This field is optional and it is only relevant when the value of Providers.Info.config-tag is Oauth2.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth2")]
        public VcenterIdentityProvidersOauth2InfoTypeA Oauth2 { get; set; }
        /// <summary>
        /// OIDC Info
        /// This field is optional and it is only relevant when the value of Providers.Info.config-tag is Oidc.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oidc")]
        public VcenterIdentityProvidersOidcInfoTypeA Oidc { get; set; }
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
        /// <summary>
        /// Communication protocol to the identity management endpoints.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "idm_protocol")]
        public VcenterIdentityProvidersIdmProtocolEnumTypeA IdmProtocol { get; set; }
        /// <summary>
        /// Identity management endpoints.
        /// This field is optional and it is only relevant when the value of Providers.Info.idm-protocol is one of REST, SCIM, or
        /// SCIM2_0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "idm_endpoints")]
        public IList<string> IdmEndpoints { get; set; }
        /// <summary>
        /// Identity management configuration.
        /// This field is optional and it is only relevant when the value of Providers.Info.idm-protocol is LDAP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_directory_over_ldap")]
        public VcenterIdentityProvidersActiveDirectoryOverLdapTypeA ActiveDirectoryOverLdap { get; set; }
        /// <summary>
        /// Specifies which claim provides the user principal name (UPN) for the user.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upn_claim")]
        public string? UpnClaim { get; set; }
        /// <summary>
        /// Specifies which claim provides the group membership for the token subject. If empty, the default behavior for CSP is
        /// used. In this case, the groups for the subject will be comprised of the groups in 'group_names' and 'group_ids' claims.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups_claim")]
        public string? GroupsClaim { get; set; }
    }
}
