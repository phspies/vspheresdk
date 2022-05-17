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
    public class VcenterVmHardwareDiskInfoTypeA 
    {
        /// <summary>
        /// Device label.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public string Label { get; set; }
        /// <summary>
        /// Type of host bus adapter to which the device is attached.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareDiskHostBusAdapterTypeEnumA Type { get; set; }
        /// <summary>
        /// Address of device attached to a virtual IDE adapter.
        /// Workaround for PR1459646
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ide")]
        public VcenterVmHardwareIdeAddressInfoTypeA Ide { get; set; }
        /// <summary>
        /// Address of device attached to a virtual SCSI adapter.
        /// Workaround for PR1459646
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scsi")]
        public VcenterVmHardwareScsiAddressInfoTypeA Scsi { get; set; }
        /// <summary>
        /// Address of device attached to a virtual SATA adapter.
        /// Workaround for PR1459646
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sata")]
        public VcenterVmHardwareSataAddressInfoTypeA Sata { get; set; }
        /// <summary>
        /// Address of device attached to a virtual NVMe adapter.
        /// This field is optional and it is only relevant when the value of Disk.Info.type is NVME.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nvme")]
        public VcenterVmHardwareNvmeAddressInfoTypeA Nvme { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing", Required = Required.AllowNull)]
        public VcenterVmHardwareDiskBackingInfoTypeA Backing { get; set; }
        /// <summary>
        /// Capacity of the virtual disk in bytes.
        /// If unset, virtual disk is inaccessible or disk capacity is 0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }
    }
}
