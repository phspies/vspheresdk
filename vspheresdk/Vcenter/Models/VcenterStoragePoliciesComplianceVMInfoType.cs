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
    public class VcenterStoragePoliciesComplianceVminfoType 
    {
        /// <summary>
        /// Compliance status of the virtual machine home.
        /// If unset or empty, virtual machine home is not associated with a storage policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home")]
        public VcenterStoragePoliciesComplianceVmstatusType VmHome { get; set; }
        /// <summary>
        /// A Map of virtual disks and their compliance status If empty, the virtual machine does not have any disks or its disks
        /// are not associated with a storage policy.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks", Required = Required.AllowNull)]
        public Dictionary<string,VcenterStoragePoliciesComplianceVmstatusType> Disks { get; set; }
    }
}
