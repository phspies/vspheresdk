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
    public class VcenterVmStoragePolicyUpdateSpecType 
    {
        /// <summary>
        /// Storage policy to be used when reconfiguring the virtual machine home.
        /// if unset the current storage policy is retained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home")]
        public VcenterVmStoragePolicyVmHomePolicySpecType VmHome { get; set; }
        /// <summary>
        /// Storage policy or policies to be used when reconfiguring virtual machine diks.
        /// if unset the current storage policy is retained.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public Dictionary<string,VcenterVmStoragePolicyDiskPolicySpecType>? Disks { get; set; }
    }
}
