using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name FormatterType} {@term enumerated type} defines supported CLI output formatter types. See {@link Info#formatter}.
    /// </summary>
    public enum VapiMetadataCliCommandFormatterTypeEnum
    {
        [EnumMember(Value = "SIMPLE")]
        SIMPLE = 1,
        [EnumMember(Value = "TABLE")]
        TABLE = 2,
        [EnumMember(Value = "JSON")]
        JSON = 3,
        [EnumMember(Value = "XML")]
        XML = 4,
        [EnumMember(Value = "CSV")]
        CSV = 5,
        [EnumMember(Value = "HTML")]
        HTML = 6,
    }
}
