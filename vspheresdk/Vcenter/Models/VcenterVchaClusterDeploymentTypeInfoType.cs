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
    public class VcenterVchaClusterDeploymentTypeInfoType 
    {
        /// <summary>
        /// Identifies the deployment type of the VCHA cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployment_type", Required = Required.AllowNull)]
        public VcenterVchaClusterDeploymentTypeTypeEnum DeploymentType { get; set; }
    }
}
