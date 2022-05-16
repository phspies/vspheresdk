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
    public class VcenterOvfLibraryItemDeployType 
    {
        /// <summary>
        /// Specification of the deployment target.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemDeploymentTargetType Target { get; set; }
        /// <summary>
        /// Specification of how the OVF package should be deployed to the target.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemResourcePoolDeploymentSpecType DeploymentSpec { get; set; }
    }
}
