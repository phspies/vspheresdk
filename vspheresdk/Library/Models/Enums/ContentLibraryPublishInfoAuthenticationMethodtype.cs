using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name AuthenticationMethod} {@term enumerated type} indicates how a subscribed library should authenticate to the published library endpoint.
    /// </summary>
    public enum ContentLibraryPublishInfoAuthenticationMethodType
    {
        [EnumMember(Value = "BASIC")]
        BASIC = 1,
        [EnumMember(Value = "NONE")]
        NONE = 2,
    }
}
