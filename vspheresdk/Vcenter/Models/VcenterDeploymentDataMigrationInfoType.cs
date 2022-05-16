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
    public class VcenterDeploymentDataMigrationInfoType 
    {
        /// <summary>
        /// Migrate only core data and configuration from vCenter Server. Events, tasks, and stats will not be migrated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "core", Required = Required.AllowNull)]
        public VcenterDeploymentDataMigrationEstimateType Core { get; set; }
        /// <summary>
        /// Migrate core, events, and tasks from vCenter Server. Stats will not be migrated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "core_events_tasks", Required = Required.AllowNull)]
        public VcenterDeploymentDataMigrationEstimateType CoreEventsTasks { get; set; }
        /// <summary>
        /// Migrate all data from vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "all", Required = Required.AllowNull)]
        public VcenterDeploymentDataMigrationEstimateType All { get; set; }
        /// <summary>
        /// Migrate core, events, and tasks from vCenter Server. Events and tasks will be migrated after the upgrade. Stats will not
        /// be migrated.
        /// This field will be available only if the source database is using an external database.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "core_events_tasks_with_deferred")]
        public VcenterDeploymentDataMigrationEstimateType CoreEventsTasksWithDeferred { get; set; }
        /// <summary>
        /// Migrate all data from vCenter Server. Events, tasks, and stats will be migrated after the upgrade.
        /// This field will be available only if the source database is using an external database.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "all_with_deferred")]
        public VcenterDeploymentDataMigrationEstimateType AllWithDeferred { get; set; }
    }
}
