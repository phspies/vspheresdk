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
    public class VcenterNamespaceManagementSupervisorServicesCustomCreateSpecType 
    {
        /// <summary>
        /// The identifier of the Supervisor Service. This has DNS_LABEL restrictions as specified in . This must be an alphanumeric
        /// (a-z and 0-9) string and with maximum length of 63 characters and with the '-' character allowed anywhere except the
        /// first or last character. This identifier must be unique across all Namespaces in this vCenter server. Additionally, the
        /// ID 'namespaces' is reserved and must not be used.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.SupervisorService. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: vcenter.namespace_management.SupervisorService.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supervisor_service", Required = Required.AllowNull)]
        public string SupervisorService { get; set; }
        /// <summary>
        /// A human readable name of the Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// A human readable description of the Supervisor Service.
        /// If unset, the Supervisor Service description will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Supervisor service version specification that provides the service definition for one Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version_spec", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpecType VersionSpec { get; set; }
    }
}
