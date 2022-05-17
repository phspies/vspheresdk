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
    public class VcenterVchaClusterDeploySpecType 
    {
        /// <summary>
        /// Contains the active node's management vCenter server credentials.
        /// If unset, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode
        /// and managed by a linked vCenter Server instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vc_spec")]
        public VcenterVchaCredentialsSpecType VcSpec { get; set; }
        /// <summary>
        /// Contains the deployment type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "deployment", Required = Required.AllowNull)]
        public VcenterVchaClusterTypeEnum Deployment { get; set; }
        /// <summary>
        /// Contains the active node's network configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active", Required = Required.AllowNull)]
        public VcenterVchaClusterActiveSpecType Active { get; set; }
        /// <summary>
        /// Contains the passive node's placement configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "passive", Required = Required.AllowNull)]
        public VcenterVchaClusterPassiveSpecType Passive { get; set; }
        /// <summary>
        /// Contains the witness node's placement configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "witness", Required = Required.AllowNull)]
        public VcenterVchaClusterWitnessSpecType Witness { get; set; }
    }
}
