using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name Location} {@term enumerated type} defines the location of subscribed library relative to the published library.
    /// </summary>
    public enum ContentLibrarySubscriptionsLocationTypeA
    {
        [EnumMember(Value = "LOCAL")]
        LOCAL = 1,
        [EnumMember(Value = "REMOTE")]
        REMOTE = 2,
    }
}
