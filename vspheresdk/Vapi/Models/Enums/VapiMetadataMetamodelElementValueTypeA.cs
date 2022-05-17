using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name Type} {@term enumerated type} defines the valid types for values in metadata elements.
    /// </summary>
    public enum VapiMetadataMetamodelElementValueTypeA
    {
        [EnumMember(Value = "LONG")]
        LONG = 1,
        [EnumMember(Value = "STRING")]
        STRING = 2,
        [EnumMember(Value = "STRING_LIST")]
        STRINGLIST = 3,
        [EnumMember(Value = "STRUCTURE_REFERENCE")]
        STRUCTUREREFERENCE = 4,
        [EnumMember(Value = "STRUCTURE_REFERENCE_LIST")]
        STRUCTUREREFERENCELIST = 5,
    }
}
