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
    public class VcenterVchaClusterVmInfoTypeA 
    {
        /// <summary>
        /// The virtual machine information of the passive node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "passive", Required = Required.AllowNull)]
        public VcenterVchaClusterNodeVmInfoTypeA Passive { get; set; }
        /// <summary>
        /// The virtual machine information of the witness node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "witness", Required = Required.AllowNull)]
        public VcenterVchaClusterNodeVmInfoTypeA Witness { get; set; }
    }
}
