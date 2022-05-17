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
    public class EsxSettingsClustersSoftwareReportsApplyImpactClusterImpactType 
    {
        /// <summary>
        /// Impact of steps performed during the setup and cleanup phase of the apply {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "impact", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsApplyImpactImpactType> Impact { get; set; }
        /// <summary>
        /// Impact summary for each host within the clsuter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_impact", Required = Required.AllowNull)]
        public object HostImpact { get; set; }
        /// <summary>
        /// Identifier of the commit on which the impact is generated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit", Required = Required.AllowNull)]
        public string Commit { get; set; }
        /// <summary>
        /// Information of hosts within the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_info", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostInfoType> HostInfo { get; set; }
    }
}
