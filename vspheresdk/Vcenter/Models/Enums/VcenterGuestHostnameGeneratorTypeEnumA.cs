using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The HostnameGenerator.Type enumerated type specifies different types of Name Generators.
    /// </summary>
    public enum VcenterGuestHostnameGeneratorTypeEnumA
    {
        [EnumMember(Value = "FIXED")]
        FIXED = 1,
        [EnumMember(Value = "PREFIX")]
        PREFIX = 2,
        [EnumMember(Value = "VIRTUAL_MACHINE")]
        VIRTUALMACHINE = 3,
        [EnumMember(Value = "USER_INPUT_REQUIRED")]
        USERINPUTREQUIRED = 4,
    }
}
