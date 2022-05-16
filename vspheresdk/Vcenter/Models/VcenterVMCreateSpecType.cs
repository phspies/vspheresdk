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
    public class VcenterVmcreateSpecType 
    {
        /// <summary>
        /// Guest OS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_OS", Required = Required.AllowNull)]
        public VcenterVmGuestOstype GuestOS { get; set; }
        /// <summary>
        /// Virtual machine name.
        /// If unset, a default name will be generated by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Virtual machine placement information.
        /// This field is currently required. In the future, if this field is unset, the system will attempt to choose suitable
        /// resources on which to place the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmplacementSpecType Placement { get; set; }
        /// <summary>
        /// Virtual hardware version.
        /// If unset, defaults to the most recent version supported by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware_version")]
        public VcenterVmHardwareVersionType HardwareVersion { get; set; }
        /// <summary>
        /// Boot configuration.
        /// If unset, guest-specific default values will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "boot")]
        public VcenterVmHardwareBootCreateSpecType Boot { get; set; }
        /// <summary>
        /// Boot device configuration.
        /// If unset, a server-specific boot sequence will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "boot_devices")]
        public Dictionary<string,VcenterVmHardwareBootDeviceEntryCreateSpecType> BootDevices { get; set; }
        /// <summary>
        /// CPU configuration.
        /// If unset, guest-specific default values will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public VcenterVmHardwareCpuUpdateType Cpu { get; set; }
        /// <summary>
        /// Memory configuration.
        /// If unset, guest-specific default values will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public VcenterVmHardwareMemoryUpdateType Memory { get; set; }
        /// <summary>
        /// List of disks.
        /// If unset, a single blank virtual disk of a guest-specific size will be created on the same storage as the virtual
        /// machine configuration, and will use a guest-specific host bus adapter type. If the guest-specific size is 0, no virtual
        /// disk will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks")]
        public Dictionary<string,VcenterVmHardwareDiskCreateType> Disks { get; set; }
        /// <summary>
        /// List of Ethernet adapters.
        /// If unset, no Ethernet adapters will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nics")]
        public Dictionary<string,VcenterVmHardwareEthernetCreateType> Nics { get; set; }
        /// <summary>
        /// List of CD-ROMs.
        /// If unset, no CD-ROM devices will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cdroms")]
        public Dictionary<string,VcenterVmHardwareCdromCreateType> Cdroms { get; set; }
        /// <summary>
        /// List of floppy drives.
        /// If unset, no floppy drives will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "floppies")]
        public Dictionary<string,VcenterVmHardwareFloppyCreateType> Floppies { get; set; }
        /// <summary>
        /// List of parallel ports.
        /// If unset, no parallel ports will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parallel_ports")]
        public Dictionary<string,VcenterVmHardwareParallelCreateType> ParallelPorts { get; set; }
        /// <summary>
        /// List of serial ports.
        /// If unset, no serial ports will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "serial_ports")]
        public Dictionary<string,VcenterVmHardwareSerialCreateType> SerialPorts { get; set; }
        /// <summary>
        /// List of SATA adapters.
        /// If unset, any adapters necessary to connect the virtual machine's storage devices will be created; this includes any
        /// devices that explicitly specify a SATA host bus adapter, as well as any devices that do not specify a host bus adapter
        /// if the guest's preferred adapter type is SATA.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sata_adapters")]
        public Dictionary<string,VcenterVmHardwareAdapterSataCreateType> SataAdapters { get; set; }
        /// <summary>
        /// List of SCSI adapters.
        /// If unset, any adapters necessary to connect the virtual machine's storage devices will be created; this includes any
        /// devices that explicitly specify a SCSI host bus adapter, as well as any devices that do not specify a host bus adapter
        /// if the guest's preferred adapter type is SCSI. The type of the SCSI adapter will be a guest-specific default type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scsi_adapters")]
        public Dictionary<string,VcenterVmHardwareAdapterScsiCreateType> ScsiAdapters { get; set; }
        /// <summary>
        /// List of NVMe adapters.
        /// If unset, any adapters necessary to connect the virtual machine's storage devices will be created; this includes any
        /// devices that explicitly specify a NVMe host bus adapter, as well as any devices that do not specify a host bus adapter
        /// if the guest's preferred adapter type is NVMe.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nvme_adapters")]
        public Dictionary<string,VcenterVmHardwareAdapterNvmeCreateType> NvmeAdapters { get; set; }
        /// <summary>
        /// The VM.StoragePolicySpec structure contains information about the storage policy that is to be associated with the
        /// virtual machine home (which contains the configuration and log files).
        /// If unset the datastore default storage policy (if applicable) is applied. Currently a default storage policy is only
        /// supported by object datastores : VVol and vSAN. For non-object datastores, if unset then no storage policy would be
        /// associated with the virtual machine home.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy")]
        public VcenterVmstoragePolicySpecType StoragePolicy { get; set; }
    }
}
