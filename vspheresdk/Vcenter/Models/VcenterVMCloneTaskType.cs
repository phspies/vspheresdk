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
    public class VcenterVmcloneTaskType 
    {
        /// <summary>
        /// Virtual machine to clone from.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        public string Source { get; set; }
        /// <summary>
        /// Virtual machine name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Virtual machine placement information.
        /// If this field is unset, the system will use the values from the source virtual machine. If specified, each field will be
        /// used for placement. If the fields result in disjoint placement the operation will fail. If the fields along with the
        /// placement values of the source virtual machine result in disjoint placement the operation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmclonePlacementSpecType Placement { get; set; }
        /// <summary>
        /// Set of Disks to Remove.
        /// If unset, all disks will be copied. If the same identifier is in VM.CloneSpec.disks-to-update InvalidArgument fault will
        /// be returned.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks_to_remove")]
        public IList<string> DisksToRemove { get; set; }
        /// <summary>
        /// Map of Disks to Update.
        /// If unset, all disks will copied to the datastore specified in the VM.ClonePlacementSpec.datastore field of
        /// VM.CloneSpec.placement. If the same identifier is in VM.CloneSpec.disks-to-remove InvalidArgument fault will be thrown.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks_to_update")]
        public Dictionary<string,VcenterVmdiskCloneSpecType>? DisksToUpdate { get; set; }
        /// <summary>
        /// Attempt to perform a VM.CloneSpec.power-on after clone.
        /// If unset, the virtual machine will not be powered on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "power_on")]
        public bool? PowerOn { get; set; }
        /// <summary>
        /// Guest customization spec to apply to the virtual machine after the virtual machine is deployed.
        /// If unset, the guest operating system is not customized after clone.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_customization_spec")]
        public VcenterVmguestCustomizationSpecType GuestCustomizationSpec { get; set; }
    }
}
