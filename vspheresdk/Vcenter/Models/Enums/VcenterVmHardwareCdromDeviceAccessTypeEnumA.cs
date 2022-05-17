using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cdrom.DeviceAccessType enumerated type defines the valid device access types for a physical device packing of a virtual CD-ROM device.
    /// </summary>
    public enum VcenterVmHardwareCdromDeviceAccessTypeEnumA
    {
        [EnumMember(Value = "EMULATION")]
        EMULATION = 1,
        [EnumMember(Value = "PASSTHRU")]
        PASSTHRU = 2,
        [EnumMember(Value = "PASSTHRU_EXCLUSIVE")]
        PASSTHRUEXCLUSIVE = 3,
    }
}
