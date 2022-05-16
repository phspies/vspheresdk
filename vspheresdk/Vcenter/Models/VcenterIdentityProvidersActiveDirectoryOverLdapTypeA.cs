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
    public class VcenterIdentityProvidersActiveDirectoryOverLdapTypeA 
    {
        /// <summary>
        /// User name to connect to the active directory server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        public string UserName { get; set; }
        /// <summary>
        /// Password to connect to the active directory server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        public string Password { get; set; }
        /// <summary>
        /// Base distinguished name for users
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "users_base_dn", Required = Required.AllowNull)]
        public string UsersBaseDn { get; set; }
        /// <summary>
        /// Base distinguished name for groups
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups_base_dn", Required = Required.AllowNull)]
        public string GroupsBaseDn { get; set; }
        /// <summary>
        /// Active directory server endpoints. At least one active directory server endpoint must be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server_endpoints", Required = Required.AllowNull)]
        public IList<string> ServerEndpoints { get; set; }
        /// <summary>
        /// SSL certificate chain in base64 encoding.
        /// This field can be unset only, if all the active directory server endpoints use the LDAP (not LDAPS) protocol.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain")]
        public VcenterCertificateManagementX509CertChainTypeA CertChain { get; set; }
    }
}
