using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name Category} {@term enumerated type} defines {@term enumeration values} for the valid kinds of values.
    /// </summary>
    public enum VapiMetadataMetamodelConstantValueCategoryType
    {
        [EnumMember(Value = "PRIMITIVE")]
        PRIMITIVE = 1,
        [EnumMember(Value = "LIST")]
        LIST = 2,
    }
}
