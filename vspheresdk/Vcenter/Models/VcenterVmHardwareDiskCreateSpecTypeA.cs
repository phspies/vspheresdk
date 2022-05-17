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
    public class VcenterVmHardwareDiskCreateSpecTypeA 
    {
        /// <summary>
        /// Type of host bus adapter to which the device should be attached.
        /// If unset, guest-specific default values will be used
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterVmHardwareDiskHostBusAdapterTypeEnumA Type { get; set; }
        /// <summary>
        /// Address for attaching the device to a virtual IDE adapter.
        /// If unset, the server will choose an available address; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ide")]
        public VcenterVmHardwareIdeAddressSpecTypeA Ide { get; set; }
        /// <summary>
        /// Address for attaching the device to a virtual SCSI adapter.
        /// If unset, the server will choose an available address; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scsi")]
        public VcenterVmHardwareScsiAddressSpecTypeA Scsi { get; set; }
        /// <summary>
        /// Address for attaching the device to a virtual SATA adapter.
        /// If unset, the server will choose an available address; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sata")]
        public VcenterVmHardwareSataAddressSpecTypeA Sata { get; set; }
        /// <summary>
        /// Address for attaching the device to a virtual NVMe adapter.
        /// If unset, the server will choose an available address; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nvme")]
        public VcenterVmHardwareNvmeAddressSpecTypeA Nvme { get; set; }
        /// <summary>
        /// Existing physical resource backing for the virtual disk. Exactly one of Disk.CreateSpec.backing or
        /// Disk.CreateSpec.new-vmdk must be specified.
        /// If unset, the virtual disk will not be connected to an existing backing.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing")]
        public VcenterVmHardwareDiskBackingSpecTypeA Backing { get; set; }
        /// <summary>
        /// Specification for creating a new VMDK backing for the virtual disk. Exactly one of Disk.CreateSpec.backing or
        /// Disk.CreateSpec.new-vmdk must be specified.
        /// If unset, a new VMDK backing will not be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_vmdk")]
        public VcenterVmHardwareDiskVmdkCreateSpecTypeA NewVmdk { get; set; }
    }
}
