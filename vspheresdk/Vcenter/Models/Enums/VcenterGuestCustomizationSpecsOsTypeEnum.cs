using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The CustomizationSpecs.OsType enumerated type defines the types of guest operating systems for which guest customization is supported.
    /// </summary>
    public enum VcenterGuestCustomizationSpecsOsTypeEnum
    {
        [EnumMember(Value = "WINDOWS")]
        WINDOWS = 1,
        [EnumMember(Value = "LINUX")]
        LINUX = 2,
    }
}
