using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsClusterComplianceType 
    {
        /// <summary>
        /// Overall impact.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "impact", Required = Required.AllowNull)]
        public EsxSettingsComplianceImpactType Impact { get; set; }
        /// <summary>
        /// Overall compliance state of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsComplianceStatusType Status { get; set; }
        /// <summary>
        /// Notifications returned by the scan operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
        /// <summary>
        /// Scan completion time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scan_time", Required = Required.AllowNull)]
        public DateTime ScanTime { get; set; }
        /// <summary>
        /// Identifier of the commit on which the scan is run to generate this result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string? Commit { get; set; }
        /// <summary>
        /// Identifiers of compliant hosts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compliant_hosts", Required = Required.AllowNull)]
        public IList<string> CompliantHosts { get; set; }
        /// <summary>
        /// Identifiers of non-compliant hosts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "non_compliant_hosts", Required = Required.AllowNull)]
        public IList<string> NonCompliantHosts { get; set; }
        /// <summary>
        /// Identifiers of incompatible hosts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatible_hosts", Required = Required.AllowNull)]
        public IList<string> IncompatibleHosts { get; set; }
        /// <summary>
        /// Identifiers of unavailable hosts. There will not be compliance details for these hosts in {@link #hosts}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "unavailable_hosts", Required = Required.AllowNull)]
        public IList<string> UnavailableHosts { get; set; }
        /// <summary>
        /// Mapping from host identifier to the compliance information for the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostComplianceType> Hosts { get; set; }
        /// <summary>
        /// Auxillary information about the hosts. This gives some additional information about the hosts referenced in this result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_info", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostInfoType> HostInfo { get; set; }
    }
}
