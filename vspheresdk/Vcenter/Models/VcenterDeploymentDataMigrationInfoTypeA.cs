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
    public class VcenterDeploymentDataMigrationInfoTypeA 
    {
        /// <summary>
        /// Migrate only core data and configuration from vCenter Server. Events, tasks, and stats will not be migrated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "core", Required = Required.AllowNull)]
        public VcenterDeploymentDataMigrationEstimateTypeA Core { get; set; }
        /// <summary>
        /// Migrate core, events, and tasks from vCenter Server. Stats will not be migrated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "core_events_tasks", Required = Required.AllowNull)]
        public VcenterDeploymentDataMigrationEstimateTypeA CoreEventsTasks { get; set; }
        /// <summary>
        /// Migrate all data from vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "all", Required = Required.AllowNull)]
        public VcenterDeploymentDataMigrationEstimateTypeA All { get; set; }
        /// <summary>
        /// Migrate core, events, and tasks from vCenter Server. Events and tasks will be migrated after the upgrade. Stats will not
        /// be migrated.
        /// This field will be available only if the source database is using an external database.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "core_events_tasks_with_deferred")]
        public VcenterDeploymentDataMigrationEstimateTypeA CoreEventsTasksWithDeferred { get; set; }
        /// <summary>
        /// Migrate all data from vCenter Server. Events, tasks, and stats will be migrated after the upgrade.
        /// This field will be available only if the source database is using an external database.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "all_with_deferred")]
        public VcenterDeploymentDataMigrationEstimateTypeA AllWithDeferred { get; set; }
    }
}
