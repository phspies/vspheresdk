using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name SourceType} {@term enumerated type} defines how the file content is retrieved.
    /// </summary>
    public enum ContentLibraryItemUpdatesessionFileSourceTypeA
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "PUSH")]
        PUSH = 2,
        [EnumMember(Value = "PULL")]
        PULL = 3,
    }
}
