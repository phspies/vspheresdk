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
    public class VcenterVmStoragePolicyComplianceCheckType 
    {
        /// <summary>
        /// Invoke compliance check on the virtual machine home directory if set to true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home", Required = Required.AllowNull)]
        public bool VmHome { get; set; }
        /// <summary>
        /// Identifiers of the virtual machine's virtual disks for which compliance should be checked.
        /// If unset or empty, compliance check is invoked on all the associated disks.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public IList<string> Disks { get; set; }
    }
}
