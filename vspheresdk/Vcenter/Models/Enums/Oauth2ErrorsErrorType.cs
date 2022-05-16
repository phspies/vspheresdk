using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Enumeration of OAuth 2.0 errors.
    /// </summary>
    public enum Oauth2ErrorsErrorType
    {
        [EnumMember(Value = "INVALID_REQUEST")]
        InvalidRequest = 1,
        [EnumMember(Value = "INVALID_SCOPE")]
        InvalidScope = 2,
        [EnumMember(Value = "INVALID_GRANT")]
        InvalidGrant = 3,
    }
}
