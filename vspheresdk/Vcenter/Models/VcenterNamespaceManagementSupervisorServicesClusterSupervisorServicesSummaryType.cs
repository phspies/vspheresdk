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
    public class VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesSummaryType 
    {
        /// <summary>
        /// The identifier of the Supervisor Service.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.SupervisorService. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: vcenter.namespace_management.SupervisorService.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supervisor_service", Required = Required.AllowNull)]
        public string SupervisorService { get; set; }
        /// <summary>
        /// The desired version of this Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_version", Required = Required.AllowNull)]
        public string DesiredVersion { get; set; }
        /// <summary>
        /// Current setting for ClusterSupervisorServices.ConfigStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesConfigStatusType ConfigStatus { get; set; }
        /// <summary>
        /// The current version for the Supervisor Service.
        /// If unset, there is no version installed for the Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        public string? CurrentVersion { get; set; }
    }
}
