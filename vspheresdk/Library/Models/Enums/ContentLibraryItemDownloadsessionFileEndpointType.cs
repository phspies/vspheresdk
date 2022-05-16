using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name EndpointType} {@term enumerated type} defines the types of endpoints used to download the file.
    /// </summary>
    public enum ContentLibraryItemDownloadsessionFileEndpointType
    {
        [EnumMember(Value = "HTTPS")]
        HTTPS = 1,
        [EnumMember(Value = "DIRECT")]
        DIRECT = 2,
    }
}
