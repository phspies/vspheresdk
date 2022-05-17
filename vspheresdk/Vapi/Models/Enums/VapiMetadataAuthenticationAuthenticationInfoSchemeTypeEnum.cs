using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name SchemeType} {@term enumerated type} provides {@term enumeration values} for the set of valid authentication scheme types.
    /// </summary>
    public enum VapiMetadataAuthenticationAuthenticationInfoSchemeTypeEnum
    {
        [EnumMember(Value = "SESSIONLESS")]
        SESSIONLESS = 1,
        [EnumMember(Value = "SESSION_AWARE")]
        SESSIONAWARE = 2,
    }
}
