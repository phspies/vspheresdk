using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ComponentSource} {@term enumerated type} contains the component&apos;s source information.
    /// </summary>
    public enum EsxSettingsComponentSourceType
    {
        [EnumMember(Value = "BASE_IMAGE")]
        BASEIMAGE = 1,
        [EnumMember(Value = "ADD_ON")]
        ADDON = 2,
        [EnumMember(Value = "USER")]
        USER = 3,
        [EnumMember(Value = "SOLUTION")]
        SOLUTION = 4,
        [EnumMember(Value = "HARDWARE_SUPPORT_PACKAGE")]
        HARDWARESUPPORTPACKAGE = 5,
    }
}
