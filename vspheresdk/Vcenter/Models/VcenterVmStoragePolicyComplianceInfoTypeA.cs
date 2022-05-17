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
    public class VcenterVmStoragePolicyComplianceInfoTypeA 
    {
        /// <summary>
        /// The overall compliance status of the virtual machine and all it's entities.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "overall_compliance", Required = Required.AllowNull)]
        public VcenterVmStoragePolicyComplianceStatusEnumTypeA OverallCompliance { get; set; }
        /// <summary>
        /// The storage policy compliance information Compliance.VmComplianceInfo for the virtual machine's home directory.
        /// If unset the virtual machine home directory has no storage policy association.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home")]
        public VcenterVmStoragePolicyComplianceVmComplianceInfoTypeA VmHome { get; set; }
        /// <summary>
        /// The compliance information Compliance.VmComplianceInfo for the virtual machine's virtual disks that are currently
        /// associated with a storage policy.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks", Required = Required.AllowNull)]
        public IList<object> Disks { get; set; }
    }
}
