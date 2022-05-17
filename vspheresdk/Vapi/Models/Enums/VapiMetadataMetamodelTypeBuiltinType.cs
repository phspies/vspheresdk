using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name BuiltinType} {@term enumerated type} provides {@term enumeration value} for each of the built-in types present in the interface definition language type system.
    /// </summary>
    public enum VapiMetadataMetamodelTypeBuiltinType
    {
        [EnumMember(Value = "VOID")]
        VOID = 1,
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN = 2,
        [EnumMember(Value = "LONG")]
        LONG = 3,
        [EnumMember(Value = "DOUBLE")]
        DOUBLE = 4,
        [EnumMember(Value = "STRING")]
        STRING = 5,
        [EnumMember(Value = "BINARY")]
        BINARY = 6,
        [EnumMember(Value = "SECRET")]
        SECRET = 7,
        [EnumMember(Value = "DATE_TIME")]
        DATETIME = 8,
        [EnumMember(Value = "ID")]
        ID = 9,
        [EnumMember(Value = "URI")]
        URI = 10,
        [EnumMember(Value = "ANY_ERROR")]
        ANYERROR = 11,
        [EnumMember(Value = "DYNAMIC_STRUCTURE")]
        DYNAMICSTRUCTURE = 12,
        [EnumMember(Value = "OPAQUE")]
        OPAQUE = 13,
    }
}
