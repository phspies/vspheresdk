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
    public class VcenterStoragePoliciesVMInfoTypeA 
    {
        /// <summary>
        /// Flag to indicate whether or not the virtual machine home is associated with the given storage policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home", Required = Required.AllowNull)]
        public bool VmHome { get; set; }
        /// <summary>
        /// List of the virtual disks that are associated with the given storage policy.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks", Required = Required.AllowNull)]
        public IList<string> Disks { get; set; }
    }
}
