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
    public class VcenterVchaClusterNodeVmInfoTypeA 
    {
        /// <summary>
        /// The identifier of the virtual machine of the VCHA node.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// VirtualMachine:VCenter. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: VirtualMachine:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm", Required = Required.AllowNull)]
        public string Vm { get; set; }
        /// <summary>
        /// BIOS UUID for the node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios_uuid", Required = Required.AllowNull)]
        public string BiosUuid { get; set; }
    }
}
