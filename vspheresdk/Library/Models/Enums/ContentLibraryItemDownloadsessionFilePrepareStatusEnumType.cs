using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name PrepareStatus} {@term enumerated type} defines the state of the file in preparation for download.
    /// </summary>
    public enum ContentLibraryItemDownloadsessionFilePrepareStatusEnumType
    {
        [EnumMember(Value = "UNPREPARED")]
        UNPREPARED = 1,
        [EnumMember(Value = "PREPARE_REQUESTED")]
        PREPAREREQUESTED = 2,
        [EnumMember(Value = "PREPARING")]
        PREPARING = 3,
        [EnumMember(Value = "PREPARED")]
        PREPARED = 4,
        [EnumMember(Value = "ERROR")]
        ERROR = 5,
    }
}
