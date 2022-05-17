using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name Type} {@term enumerated type} defines the valid types for values in constant elements.
    /// </summary>
    public enum VapiMetadataMetamodelPrimitiveValueTypeA
    {
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN = 1,
        [EnumMember(Value = "DOUBLE")]
        DOUBLE = 2,
        [EnumMember(Value = "LONG")]
        LONG = 3,
        [EnumMember(Value = "STRING")]
        STRING = 4,
    }
}
