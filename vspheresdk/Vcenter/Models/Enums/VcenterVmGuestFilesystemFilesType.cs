using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Files.Type enumerated type defines the valid types of files.
    /// </summary>
    public enum VcenterVmGuestFilesystemFilesType
    {
        [EnumMember(Value = "FILE")]
        FILE = 1,
        [EnumMember(Value = "DIRECTORY")]
        DIRECTORY = 2,
        [EnumMember(Value = "SYMLINK")]
        SYMLINK = 3,
    }
}
