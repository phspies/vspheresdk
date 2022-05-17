using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Device.Type enumerated type defines the valid device types that may be used as bootable devices.
    /// </summary>
    public enum VcenterVmHardwareBootDeviceTypeEnum
    {
        [EnumMember(Value = "CDROM")]
        CDROM = 1,
        [EnumMember(Value = "DISK")]
        DISK = 2,
        [EnumMember(Value = "ETHERNET")]
        ETHERNET = 3,
        [EnumMember(Value = "FLOPPY")]
        FLOPPY = 4,
    }
}
