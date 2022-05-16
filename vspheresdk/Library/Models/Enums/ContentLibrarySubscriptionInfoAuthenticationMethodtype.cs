using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// Indicate how the subscribed library should authenticate with the published library endpoint.
    /// </summary>
    public enum ContentLibrarySubscriptionInfoAuthenticationMethodType
    {
        [EnumMember(Value = "BASIC")]
        BASIC = 1,
        [EnumMember(Value = "NONE")]
        NONE = 2,
    }
}
