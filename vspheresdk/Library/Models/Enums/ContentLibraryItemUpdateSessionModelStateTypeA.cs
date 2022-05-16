using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The state of an update session.
    /// </summary>
    public enum ContentLibraryItemUpdateSessionModelStateTypeA
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,
        [EnumMember(Value = "DONE")]
        DONE = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
        [EnumMember(Value = "CANCELED")]
        CANCELED = 4,
    }
}
