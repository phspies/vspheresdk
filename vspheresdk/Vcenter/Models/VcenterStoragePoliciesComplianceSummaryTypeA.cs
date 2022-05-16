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
    public class VcenterStoragePoliciesComplianceSummaryTypeA 
    {
        /// <summary>
        /// Identifier of virtual machine
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm", Required = Required.AllowNull)]
        public string Vm { get; set; }
        /// <summary>
        /// Compliance status of the virtual machine home.
        /// If unset or empty, vmHome is not associated with a storage policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home")]
        public VcenterStoragePoliciesComplianceStatusTypeA VmHome { get; set; }
        /// <summary>
        /// List of the virtual hard disk.
        /// If unset or empty, virtual machine entity does not have any disks or its disks are not associated with a storage policy.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public IList<object> Disks { get; set; }
    }
}
