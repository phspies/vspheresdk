using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Disk.HostBusAdapterType enumerated type defines the valid types of host bus adapters that may be used for attaching a virtual storage device to a virtual machine.
    /// </summary>
    public enum VcenterVmHardwareDiskHostBusAdapterType
    {
        [EnumMember(Value = "IDE")]
        IDE = 1,
        [EnumMember(Value = "SCSI")]
        SCSI = 2,
        [EnumMember(Value = "SATA")]
        SATA = 3,
        [EnumMember(Value = "NVME")]
        NVME = 4,
    }
}
