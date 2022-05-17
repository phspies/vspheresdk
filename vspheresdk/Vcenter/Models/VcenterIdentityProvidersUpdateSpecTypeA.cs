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
    public class VcenterIdentityProvidersUpdateSpecTypeA 
    {
        /// <summary>
        /// The config type of the identity provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_tag", Required = Required.AllowNull)]
        public VcenterIdentityProvidersConfigTypeEnumA ConfigTag { get; set; }
        /// <summary>
        /// OAuth2 UpdateSpec
        /// This field is optional and it is only relevant when the value of Providers.UpdateSpec.config-tag is Oauth2.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oauth2")]
        public VcenterIdentityProvidersOauth2UpdateSpecTypeA Oauth2 { get; set; }
        /// <summary>
        /// OIDC UpdateSpec
        /// This field is optional and it is only relevant when the value of Providers.UpdateSpec.config-tag is Oidc.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "oidc")]
        public VcenterIdentityProvidersOidcUpdateSpecTypeA Oidc { get; set; }
        /// <summary>
        /// The set orgIds as part of SDDC creation which provides the basis for tenancy
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "org_ids")]
        public IList<string> OrgIds { get; set; }
        /// <summary>
        /// Specifies whether to make this the default provider. If Providers.UpdateSpec.make-default is set to true, this provider
        /// will be flagged as the default provider and any other providers that had previously been flagged as the default will be
        /// made non-default. If Providers.UpdateSpec.make-default is set to false, this provider's default flag will not be
        /// modified.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "make_default")]
        public bool? MakeDefault { get; set; }
        /// <summary>
        /// The user friendly name for the provider. This name can be used for human-readable identification purposes, but it does
        /// not have to be unique, as the system will use internal UUIDs to differentiate providers.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Set of fully qualified domain names to trust when federating with this identity provider. Tokens from this identity
        /// provider will only be validated if the user belongs to one of these domains, and any domain-qualified groups in the
        /// tokens will be filtered to include only those groups that belong to one of these domains.
        /// If unset, leaves value unchanged. If domainNames is an empty set, domain validation behavior at login with this identity
        /// provider will be as follows: the user's domain will be parsed from the User Principal Name (UPN) value that is found in
        /// the tokens returned by the identity provider. This domain will then be implicitly trusted and used to filter any groups
        /// that are also provided in the tokens.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain_names")]
        public IList<string> DomainNames { get; set; }
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
        public IList<object> AuthQueryParams { get; set; }
        /// <summary>
        /// The protocol to communicate to the identity management endpoints
        /// If unset, leave value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "idm_protocol")]
        public VcenterIdentityProvidersIdmProtocolEnumTypeA IdmProtocol { get; set; }
        /// <summary>
        /// Identity management endpoints. When specified, at least one endpoint must be provided.
        /// This field is optional and it is only relevant when the value of Providers.UpdateSpec.idm-protocol is one of REST, SCIM,
        /// or SCIM2_0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "idm_endpoints")]
        public IList<string> IdmEndpoints { get; set; }
        /// <summary>
        /// Identity management configuration. If the protocol is LDAP, the configuration must be set, else InvalidArgument is
        /// thrown
        /// This field is optional and it is only relevant when the value of Providers.UpdateSpec.idm-protocol is LDAP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_directory_over_ldap")]
        public VcenterIdentityProvidersActiveDirectoryOverLdapTypeA ActiveDirectoryOverLdap { get; set; }
        /// <summary>
        /// Specifies which claim provides the user principal name (UPN) for the subject of the token.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upn_claim")]
        public string? UpnClaim { get; set; }
        /// <summary>
        /// Flag indicating whether the user principal name (UPN) claim should be set back to its default value. If this field is
        /// set to true, the user principal name (UPN) claim will be set to 'acct', which is used for backwards compatibility with
        /// CSP. If this field is set to false, the existing user principal name (UPN) claim will be changed to the value specified
        /// in Providers.UpdateSpec.upn-claim, if any.
        /// If unset, the existing user principal name (UPN) claim will be changed to the value specified in
        /// Providers.UpdateSpec.upn-claim, if any.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reset_upn_claim")]
        public bool? ResetUpnClaim { get; set; }
        /// <summary>
        /// Specifies which claim provides the group membership for the token subject.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups_claim")]
        public string? GroupsClaim { get; set; }
        /// <summary>
        /// Flag indicating whether any existing groups claim value should be removed. If this field is set to true, the existing
        /// groups claim value is removed which defaults to backwards compatibility with CSP. In this case, the groups for the
        /// subject will be comprised of the groups in 'group_names' and 'group_ids' claims. If this field is set to false, the
        /// existing groups claim will be changed to the value specified in Providers.UpdateSpec.groups-claim, if any.
        /// If unset, the existing groups claim will be changed to the value specified in Providers.UpdateSpec.groups-claim, if any.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reset_groups_claim")]
        public bool? ResetGroupsClaim { get; set; }
    }
}
