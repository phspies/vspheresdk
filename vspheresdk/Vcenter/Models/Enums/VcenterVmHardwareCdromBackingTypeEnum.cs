using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cdrom.BackingType enumerated type defines the valid backing types for a virtual CD-ROM device.
    /// </summary>
    public enum VcenterVmHardwareCdromBackingTypeEnum
    {
        [EnumMember(Value = "ISO_FILE")]
        ISOFILE = 1,
        [EnumMember(Value = "HOST_DEVICE")]
        HOSTDEVICE = 2,
        [EnumMember(Value = "CLIENT_DEVICE")]
        CLIENTDEVICE = 3,
    }
}
