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
    public class EsxSettingsClustersSoftwareReportsLastCheckResultEntityCheckResultType 
    {
        /// <summary>
        /// The entity type for which these checks are being run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastCheckResultEntityCheckResultEntityType Type { get; set; }
        /// <summary>
        /// If the entity type is CLUSTER then the cluster identifier for which the checks have been run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// If the entity type is HOST then the host identifier for which the checks have been run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Aggregated status from all checks performed on this entity.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsLastCheckResultStatusType Status { get; set; }
        /// <summary>
        /// List of {@name CheckStatus} for all checks performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_statuses", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsLastCheckResultCheckStatusType> CheckStatuses { get; set; }
    }
}
