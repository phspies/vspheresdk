using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name GenericType} {@term enumerated type} provides {@term enumeration values} for each of the generic types provided by the infrastructure.
    /// </summary>
    public enum VapiMetadataMetamodelGenericInstantiationGenericTypeEnum
    {
        [EnumMember(Value = "LIST")]
        LIST = 1,
        [EnumMember(Value = "MAP")]
        MAP = 2,
        [EnumMember(Value = "OPTIONAL")]
        OPTIONAL = 3,
        [EnumMember(Value = "SET")]
        SET = 4,
    }
}
