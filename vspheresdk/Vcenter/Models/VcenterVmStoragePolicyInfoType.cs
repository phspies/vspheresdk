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
    public class VcenterVmStoragePolicyInfoType 
    {
        /// <summary>
        /// Storage Policy associated with virtual machine home.
        /// Ifunset, the virtual machine's home directory doesn't have any storage policy.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.StoragePolicy. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vcenter.StoragePolicy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home")]
        public string? VmHome { get; set; }
        /// <summary>
        /// Storage policies associated with virtual disks. The values in this map are storage policy identifiers. They will be
        /// identifiers for the resource type:vcenter.StoragePolicy If the map is empty, the virtual machine does not have any disks
        /// or its disks are not associated with a storage policy.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks", Required = Required.AllowNull)]
        public object Disks { get; set; }
    }
}
