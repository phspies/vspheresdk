using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Domain.Type enumerated type defines the types of network the virtual machine should join to after the customization is completed.
    /// </summary>
    public enum VcenterGuestDomainTypeEnumA
    {
        [EnumMember(Value = "WORKGROUP")]
        WORKGROUP = 1,
        [EnumMember(Value = "DOMAIN")]
        DOMAIN = 2,
    }
}
