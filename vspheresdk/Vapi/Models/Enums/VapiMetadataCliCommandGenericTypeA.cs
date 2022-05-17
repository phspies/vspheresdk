using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name GenericType} {@term enumerated type} defines generic types supported by {@name Command} {@term service}. See {@link OptionInfo#generic}.
    /// </summary>
    public enum VapiMetadataCliCommandGenericTypeA
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "OPTIONAL")]
        OPTIONAL = 2,
        [EnumMember(Value = "LIST")]
        LIST = 3,
        [EnumMember(Value = "OPTIONAL_LIST")]
        OPTIONALLIST = 4,
        [EnumMember(Value = "LIST_OPTIONAL")]
        LISTOPTIONAL = 5,
    }
}
