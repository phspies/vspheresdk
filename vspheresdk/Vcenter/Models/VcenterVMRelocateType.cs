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
    public class VcenterVmrelocateType 
    {
        /// <summary>
        /// Virtual machine placement information.
        /// If this field is unset, the system will use the values from the source virtual machine. If specified, each field will be
        /// used for placement. If the fields result in disjoint placement the operation will fail. If the fields along with the
        /// other existing placement of the virtual machine result in disjoint placement the operation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmrelocatePlacementSpecType Placement { get; set; }
        /// <summary>
        /// Individual disk relocation map.
        /// If unset, all disks will migrate to the datastore specified in the VM.RelocatePlacementSpec.datastore field of
        /// VM.RelocateSpec.placement.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public Dictionary<string,VcenterVmdiskRelocateSpecType>? Disks { get; set; }
    }
}
