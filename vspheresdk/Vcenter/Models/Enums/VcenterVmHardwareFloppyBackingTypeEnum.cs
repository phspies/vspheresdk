using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Floppy.BackingType enumerated type defines the valid backing types for a virtual floppy drive.
    /// </summary>
    public enum VcenterVmHardwareFloppyBackingTypeEnum
    {
        [EnumMember(Value = "IMAGE_FILE")]
        IMAGEFILE = 1,
        [EnumMember(Value = "HOST_DEVICE")]
        HOSTDEVICE = 2,
        [EnumMember(Value = "CLIENT_DEVICE")]
        CLIENTDEVICE = 3,
    }
}
