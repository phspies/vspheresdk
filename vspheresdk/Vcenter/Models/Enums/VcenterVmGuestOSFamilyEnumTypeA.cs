using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The GuestOSFamily enumerated type defines the valid guest operating system family types reported by a virtual machine.
    /// </summary>
    public enum VcenterVmGuestOSFamilyEnumTypeA
    {
        [EnumMember(Value = "WINDOWS")]
        WINDOWS = 1,
        [EnumMember(Value = "LINUX")]
        LINUX = 2,
        [EnumMember(Value = "NETWARE")]
        NETWARE = 3,
        [EnumMember(Value = "SOLARIS")]
        SOLARIS = 4,
        [EnumMember(Value = "DARWIN")]
        DARWIN = 5,
        [EnumMember(Value = "OTHER")]
        OTHER = 6,
    }
}
