using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cdrom.HostBusAdapterType enumerated type defines the valid types of host bus adapters that may be used for attaching a Cdrom to a virtual machine.
    /// </summary>
    public enum VcenterVmHardwareCdromHostBusAdapterTypeA
    {
        [EnumMember(Value = "IDE")]
        IDE = 1,
        [EnumMember(Value = "SATA")]
        SATA = 2,
    }
}
