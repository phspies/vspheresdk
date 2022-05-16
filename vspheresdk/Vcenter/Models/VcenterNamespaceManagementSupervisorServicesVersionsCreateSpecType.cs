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
    public class VcenterNamespaceManagementSupervisorServicesVersionsCreateSpecType 
    {
        /// <summary>
        /// The specification required to create a Supervisor Service version from inline content that is based on a plain
        /// Kubernetes YAML format.
        /// 
        /// 
        /// If set, the service version will be created from inline content based on a plain Kubernetes YAML format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "custom_spec")]
        public VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpecType CustomSpec { get; set; }
        /// <summary>
        /// The specification required to create a Supervisor Service version from inline content that is based on the vSphere
        /// application service format.
        /// 
        /// 
        /// If set, the service version will be created from inline content based on the vSphere application service format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_spec")]
        public VcenterNamespaceManagementSupervisorServicesVersionsVsphereCreateSpecType VsphereSpec { get; set; }
    }
}
