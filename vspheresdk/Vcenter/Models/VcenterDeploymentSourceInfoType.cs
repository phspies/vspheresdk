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
    public class VcenterDeploymentSourceInfoType 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the source vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// Source vCenter Server version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Deployment type of the source vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployment_type", Required = Required.AllowNull)]
        public VcenterDeploymentApplianceTypeEnum DeploymentType { get; set; }
        /// <summary>
        /// Deployment size of the source vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployment_size", Required = Required.AllowNull)]
        public VcenterDeploymentApplianceSizeEnumType DeploymentSize { get; set; }
        /// <summary>
        /// The SSO domain name of the source vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_domain_name", Required = Required.AllowNull)]
        public string SsoDomainName { get; set; }
        /// <summary>
        /// The domain name of the Active Directory server to which the source vCenter Server is joined.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_directory_domain", Required = Required.AllowNull)]
        public string ActiveDirectoryDomain { get; set; }
        /// <summary>
        /// IP addresses of the DNS servers of the Active Directory server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers", Required = Required.AllowNull)]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// Contains all the available migrate options, estimated export and import time and the space required to migrate the data.
        /// This field will be available if estimate data is available for the appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "data_migration_info")]
        public VcenterDeploymentDataMigrationInfoType DataMigrationInfo { get; set; }
    }
}
