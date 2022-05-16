using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name State} {@term enumerated type} defines the state of the update session&apos;s preview.
    /// </summary>
    public enum ContentLibraryItemUpdatesessionPreviewInfoStateType
    {
        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE = 1,
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOTAPPLICABLE = 2,
        [EnumMember(Value = "PREPARING")]
        PREPARING = 3,
        [EnumMember(Value = "AVAILABLE")]
        AVAILABLE = 4,
    }
}
