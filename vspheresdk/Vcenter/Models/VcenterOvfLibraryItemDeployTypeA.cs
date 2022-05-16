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
    public class VcenterOvfLibraryItemDeployTypeA 
    {
        /// <summary>
        /// Client-generated token used to retry a request if the client fails to get a response from the server. If the original
        /// request succeeded, the result of that request will be returned, otherwise the operation will be retried.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_token")]
        public string? ClientToken { get; set; }
        /// <summary>
        /// Specification of the deployment target.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemDeploymentTargetTypeA Target { get; set; }
        /// <summary>
        /// Specification of how the OVF package should be deployed to the target.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployment_spec", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemResourcePoolDeploymentSpecTypeA DeploymentSpec { get; set; }
    }
}
