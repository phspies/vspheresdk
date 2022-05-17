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
    public class VcenterIdentityProvidersCreateType 
    {
        /// <summary>
        /// The config type of the identity provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_tag", Required = Required.AllowNull)]
        public VcenterIdentityProvidersConfigTypeEnum ConfigTag { get; set; }
        /// <summary>
        /// OAuth2 CreateSpec
        /// This field is optional and it is only relevant when the value of Providers.CreateSpec.config-tag is Oauth2.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth2")]
        public VcenterIdentityProvidersOauth2CreateSpecType Oauth2 { get; set; }
        /// <summary>
        /// OIDC CreateSpec
        /// This field is optional and it is only relevant when the value of Providers.CreateSpec.config-tag is Oidc.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oidc")]
        public VcenterIdentityProvidersOidcCreateSpecType Oidc { get; set; }
        /// <summary>
        /// The set of orgIds as part of SDDC creation which provides the basis for tenancy
        /// If unset, the set will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "org_ids")]
        public IList<string> OrgIds { get; set; }
        /// <summary>
        /// Specifies whether the provider is the default provider. Setting Providers.CreateSpec.is-default of current provider to
        /// True makes all other providers non-default. If no other providers created in this vCenter Server before, this parameter
        /// will be disregarded, and the provider will always be set to the default.
        /// If unset the provider will be the default provider if it is the first provider that is created, and will not be the
        /// default provider otherwise.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// The user friendly name for the provider. This name can be used for human-readable identification purposes, but it does
        /// not have to be unique, as the system will use internal UUIDs to differentiate providers.
        /// If unset, the name will be the empty string
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Set of fully qualified domain names to trust when federating with this identity provider. Tokens from this identity
        /// provider will only be validated if the user belongs to one of these domains, and any domain-qualified groups in the
        /// tokens will be filtered to include only those groups that belong to one of these domains.
        /// If unset, domainNames will be the empty set and the domain validation behavior at login with this identity provider will
        /// be as follows: the user's domain will be parsed from the User Principal Name (UPN) value that is found in the tokens
        /// returned by the identity provider. This domain will then be implicitly trusted and used to filter any groups that are
        /// also provided in the tokens.
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
        /// If unset, the map will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_query_params")]
        public object AuthQueryParams { get; set; }
        /// <summary>
        /// Communication protocol to the identity management endpoints.
        /// If unset, no communication protocol will be configured for the identity provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "idm_protocol")]
        public VcenterIdentityProvidersIdmProtocolEnumType IdmProtocol { get; set; }
        /// <summary>
        /// Identity management endpoints. When specified, at least one endpoint must be provided.
        /// This field is optional and it is only relevant when the value of Providers.CreateSpec.idm-protocol is one of REST, SCIM,
        /// or SCIM2_0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "idm_endpoints")]
        public IList<string> IdmEndpoints { get; set; }
        /// <summary>
        /// Identity management configuration. If the protocol is LDAP, the configuration must be set, else InvalidArgument is
        /// thrown.
        /// This field is optional and it is only relevant when the value of Providers.CreateSpec.idm-protocol is LDAP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_directory_over_ldap")]
        public VcenterIdentityProvidersActiveDirectoryOverLdapType ActiveDirectoryOverLdap { get; set; }
        /// <summary>
        /// Specifies which claim provides the user principal name (UPN) for the user.
        /// If unset, the claim named 'acct' will be used to provide backwards compatibility with CSP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upn_claim")]
        public string? UpnClaim { get; set; }
        /// <summary>
        /// Specifies which claim provides the group membership for the token subject. These groups will be used for mapping to
        /// local groups per the claim map.
        /// If unset, the default behavior will be CSP backwards compatiblility. The groups for the subject will be comprised of the
        /// groups in 'group_names' and 'group_ids' claims.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups_claim")]
        public string? GroupsClaim { get; set; }
    }
}
