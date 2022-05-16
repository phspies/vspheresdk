using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The state of the download session.
    /// </summary>
    public enum ContentLibraryItemDownloadSessionModelStateType
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,
        [EnumMember(Value = "CANCELED")]
        CANCELED = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
    }
}
