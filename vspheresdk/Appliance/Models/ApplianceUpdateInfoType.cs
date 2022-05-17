using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceUpdateInfoType 
    {
        /// <summary>
        /// State of the appliance update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public ApplianceUpdateStateEnumType State { get; set; }
        /// <summary>
        /// The running or completed update task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "task")]
        public ApplianceTaskInfoType Task { get; set; }
        /// <summary>
        /// Version of base appliance if state is UP_TO_DATE Version of update being staged or installed if state is
        /// INSTALL_IN_PROGRESS or STAGE_IN_PROGRESS Version of update staged if state is UPDATES_PENDING Version of update failed
        /// if state is INSTALL_FAILED or ROLLBACK_IN_PROGRESS
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Timestamp of latest query to update repository.
        /// If unset the update was never queried
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "latest_query_time")]
        public DateTime? LatestQueryTime { get; set; }
    }
}
