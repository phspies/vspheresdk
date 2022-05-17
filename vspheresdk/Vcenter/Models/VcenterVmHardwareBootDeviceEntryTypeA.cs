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
    public class VcenterVmHardwareBootDeviceEntryTypeA 
    {
        /// <summary>
        /// Virtual device type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareBootDeviceTypeEnumA Type { get; set; }
        /// <summary>
        /// Virtual Ethernet device. Ethernet device to use as boot device for this entry.
        /// This field is optional and it is only relevant when the value of Device.Entry.type is ETHERNET.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.Ethernet. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.vm.hardware.Ethernet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nic")]
        public string? Nic { get; set; }
        /// <summary>
        /// Virtual disk device. List of virtual disks in boot order.
        /// This field is optional and it is only relevant when the value of Device.Entry.type is DISK.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public IList<string> Disks { get; set; }
    }
}
