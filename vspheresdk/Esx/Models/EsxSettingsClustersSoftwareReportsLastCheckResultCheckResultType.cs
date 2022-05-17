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
    public class EsxSettingsClustersSoftwareReportsLastCheckResultCheckResultType 
    {
        /// <summary>
        /// Aggregated status from all checks performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastCheckResultStatusType Status { get; set; }
        /// <summary>
        /// Time when the operation started.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time", Required = Required.AllowNull)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Time when the operation completed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time", Required = Required.AllowNull)]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// The identifier of the commit on which checks have been run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit", Required = Required.AllowNull)]
        public string Commit { get; set; }
        /// <summary>
        /// Information about the hosts in this cluster for which checks have been requested to be run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_info", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostInfoType> HostInfo { get; set; }
        /// <summary>
        /// List of {@name EntityCheckResult} for all entities for which checks have been run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity_results", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsLastCheckResultEntityCheckResultType> EntityResults { get; set; }
    }
}
