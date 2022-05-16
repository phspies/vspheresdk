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
    public class VcenterVMInfoTypeA 
    {
        /// <summary>
        /// Guest OS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_OS", Required = Required.AllowNull)]
        public VcenterVmGuestOstypeA GuestOS { get; set; }
        /// <summary>
        /// Virtual machine name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Identity of the virtual machine.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VcenterVmIdentityInfoTypeA Identity { get; set; }
        /// <summary>
        /// Power state of the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "power_state", Required = Required.AllowNull)]
        public VcenterVmPowerStateTypeA PowerState { get; set; }
        /// <summary>
        /// Indicates whether the virtual machine is frozen for instant clone, or not.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "instant_clone_frozen")]
        public bool? InstantCloneFrozen { get; set; }
        /// <summary>
        /// Virtual hardware version information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware", Required = Required.AllowNull)]
        public VcenterVmHardwareInfoTypeA Hardware { get; set; }
        /// <summary>
        /// Boot configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "boot", Required = Required.AllowNull)]
        public VcenterVmHardwareBootInfoTypeA Boot { get; set; }
        /// <summary>
        /// Boot device configuration. If the list has no entries, a server-specific default boot sequence is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "boot_devices", Required = Required.AllowNull)]
        public Dictionary<string,VcenterVmHardwareBootDeviceEntryTypeA> BootDevices { get; set; }
        /// <summary>
        /// CPU configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu", Required = Required.AllowNull)]
        public VcenterVmHardwareCpuInfoTypeA Cpu { get; set; }
        /// <summary>
        /// Memory configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory", Required = Required.AllowNull)]
        public VcenterVmHardwareMemoryInfoTypeA Memory { get; set; }
        /// <summary>
        /// List of disks.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Disk. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks", Required = Required.AllowNull)]
        public IList<object> Disks { get; set; }
        /// <summary>
        /// List of Ethernet adapters.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Ethernet. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.Ethernet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nics", Required = Required.AllowNull)]
        public IList<object> Nics { get; set; }
        /// <summary>
        /// List of CD-ROMs.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Cdrom. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Cdrom.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cdroms", Required = Required.AllowNull)]
        public IList<object> Cdroms { get; set; }
        /// <summary>
        /// List of floppy drives.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Floppy. When operations return a value of this structure as a result, the key in the
        /// field map will be an identifier for the resource type: vcenter.vm.hardware.Floppy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "floppies", Required = Required.AllowNull)]
        public IList<object> Floppies { get; set; }
        /// <summary>
        /// List of parallel ports.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.ParallelPort. When operations return a value of this structure as a result, the key
        /// in the field map will be an identifier for the resource type: vcenter.vm.hardware.ParallelPort.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parallel_ports", Required = Required.AllowNull)]
        public IList<object> ParallelPorts { get; set; }
        /// <summary>
        /// List of serial ports.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.SerialPort. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.SerialPort.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "serial_ports", Required = Required.AllowNull)]
        public IList<object> SerialPorts { get; set; }
        /// <summary>
        /// List of SATA adapters.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.SataAdapter. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.SataAdapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sata_adapters", Required = Required.AllowNull)]
        public IList<object> SataAdapters { get; set; }
        /// <summary>
        /// List of SCSI adapters.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.ScsiAdapter. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.ScsiAdapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scsi_adapters", Required = Required.AllowNull)]
        public IList<object> ScsiAdapters { get; set; }
        /// <summary>
        /// List of NVMe adapters.
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.NvmeAdapter. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.NvmeAdapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nvme_adapters")]
        public IList<object> NvmeAdapters { get; set; }
    }
}
