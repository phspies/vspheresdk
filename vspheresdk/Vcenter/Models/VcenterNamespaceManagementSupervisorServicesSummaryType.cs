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
    public class VcenterNamespaceManagementSupervisorServicesSummaryType 
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
        /// The human readable name of the Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// The current SupervisorServices.State of the Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesStateEnumType State { get; set; }
    }
}
