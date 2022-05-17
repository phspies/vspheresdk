using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name Category} {@term enumerated type} provides {@term enumeration value} for each category of the type.
    /// </summary>
    public enum VapiMetadataMetamodelTypeCategoryEnumTypeA
    {
        [EnumMember(Value = "BUILTIN")]
        BUILTIN = 1,
        [EnumMember(Value = "USER_DEFINED")]
        USERDEFINED = 2,
        [EnumMember(Value = "GENERIC")]
        GENERIC = 3,
    }
}
