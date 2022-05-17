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
    public class EsxSettingsClustersSoftwareReportsLastApplyResultApplyResultType 
    {
        /// <summary>
        /// Specifies the aggregated status of the apply {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastApplyResultApplyStatusType Status { get; set; }
        /// <summary>
        /// The identifier of the commit used to fetch the desired software document to be applied to all hosts within the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit", Required = Required.AllowNull)]
        public string Commit { get; set; }
        /// <summary>
        /// Information of the hosts in this cluster to which the desired software document specified by the {@link #commit} should
        /// be applied to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_info", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostInfoType> HostInfo { get; set; }
        /// <summary>
        /// Status of the hosts in this cluster to which the desired software document specified by the {@link #commit} was applied
        /// to. Hosts on which the apply {@term operation} was sucessful are specified by {@link #successfulHosts}. Hosts on which
        /// the apply {@term operation} failed are specified by {@link #failedHosts}. Hosts which were skipped by the apply {@term
        /// operation} are specified by {@link #skippedHosts}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_status", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsLastApplyResultApplyStatusType> HostStatus { get; set; }
        /// <summary>
        /// Hosts in this cluster to which the desired software document specified by the {@link #commit} has been successfully
        /// applied to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "successful_hosts", Required = Required.AllowNull)]
        public IList<string> SuccessfulHosts { get; set; }
        /// <summary>
        /// Hosts in this cluster to which the desired software document specified by the {@link #commit} failed to be applied to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failed_hosts", Required = Required.AllowNull)]
        public IList<string> FailedHosts { get; set; }
        /// <summary>
        /// Hosts in this cluster that were skipped by the apply {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipped_hosts", Required = Required.AllowNull)]
        public IList<string> SkippedHosts { get; set; }
        /// <summary>
        /// Notifications providing additional information for {@link esx.settings.clusters.Software#apply} {@term operation}. These
        /// notifications are mutually exclusive with the notifications in {@name ApplyStatus}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications")]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
