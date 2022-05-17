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
    public class VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesSetType 
    {
        /// <summary>
        /// Identifier of the Supervisor Service version which contains the service definition. This Supervisor Service version must
        /// be in the ACTIVATED state.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.supervisor_services.Version. When operations return a value of this structure as a result,
        /// the field will be an identifier for the resource type: vcenter.namespace_management.supervisor_services.Version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// A generic key-value map for additional configuration parameters required during service upgrade. As an example, a third
        /// party operator might reference a private registry using parameters such as "registryName" for the registry name,
        /// "registryUsername" and "registryPassword" for the registry credentials.
        /// If unset, no additional configuration parameters will be applied when upgrading a Supervisor Service in the vSphere
        /// Supervisor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service_config")]
        public object ServiceConfig { get; set; }
    }
}
