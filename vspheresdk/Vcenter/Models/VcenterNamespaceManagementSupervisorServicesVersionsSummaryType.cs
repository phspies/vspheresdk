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
    public class VcenterNamespaceManagementSupervisorServicesVersionsSummaryType 
    {
        /// <summary>
        /// The identifier of the Supervisor Service version.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.supervisor_services.Version. When operations return a value of this structure as a result,
        /// the field will be an identifier for the resource type: vcenter.namespace_management.supervisor_services.Version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// A human readable name of the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// The current Versions.State of the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesVersionsStateEnumType State { get; set; }
        /// <summary>
        /// A human readable description of the Supervisor Service version.
        /// If unset, no description is available for the service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
