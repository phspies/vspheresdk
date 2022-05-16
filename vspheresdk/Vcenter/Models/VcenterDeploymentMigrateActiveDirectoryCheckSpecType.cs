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
    public class VcenterDeploymentMigrateActiveDirectoryCheckSpecType 
    {
        /// <summary>
        /// IP addresses of the DNS servers of the Active Directory server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers", Required = Required.AllowNull)]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// The domain name of the Active Directory server to which the migrated vCenter Server appliance should be joined.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain", Required = Required.AllowNull)]
        public string Domain { get; set; }
        /// <summary>
        /// Active Directory user that has permission to join the Active Directory after the vCenter Server is migrated to
        /// appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// Active Directory user password that has permission to join the Active Directory after the vCenter Server is migrated to
        /// appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        public string Password { get; set; }
    }
}
