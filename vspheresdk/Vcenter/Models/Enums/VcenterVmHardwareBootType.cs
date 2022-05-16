using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Boot.Type enumerated type defines the valid firmware types for a virtual machine.
    /// </summary>
    public enum VcenterVmHardwareBootType
    {
        [EnumMember(Value = "BIOS")]
        BIOS = 1,
        [EnumMember(Value = "EFI")]
        EFI = 2,
    }
}
