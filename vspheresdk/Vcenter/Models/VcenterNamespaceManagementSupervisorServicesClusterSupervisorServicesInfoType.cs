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
    public class VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesInfoType 
    {
        /// <summary>
        /// The desired version of this Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_version", Required = Required.AllowNull)]
        public string DesiredVersion { get; set; }
        /// <summary>
        /// Identifier of the namespace to allocate the Supervisor Service's operators.
        /// If unset, there is an error when creating the service namespace or the namespace has not been created yet.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service_namespace")]
        public string? ServiceNamespace { get; set; }
        /// <summary>
        /// Current setting for ClusterSupervisorServices.ConfigStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesConfigStatusType ConfigStatus { get; set; }
        /// <summary>
        /// Current set of messages associated with the Supervisor Service on the vSphere Supervisor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementSupervisorServicesClusterSupervisorServicesMessageType> Messages { get; set; }
        /// <summary>
        /// The current version for the Supervisor Service.
        /// If unset, there is no version installed for the Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// A human readable name of the Supervisor Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// A human readable description of the Supervisor Service.
        /// If unset, the description for the service version is empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The prefix that will be added to the names of the Supervisor Service's kubernetes resources.
        /// If unset, the prefix is not assigned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string? Prefix { get; set; }
    }
}
