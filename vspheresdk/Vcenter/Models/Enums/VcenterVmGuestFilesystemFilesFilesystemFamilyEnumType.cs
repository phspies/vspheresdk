using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Files.FilesystemFamily enumerated type defines the types of guest operating fllesystem.
    /// </summary>
    public enum VcenterVmGuestFilesystemFilesFilesystemFamilyEnumType
    {
        [EnumMember(Value = "WINDOWS")]
        WINDOWS = 1,
        [EnumMember(Value = "POSIX")]
        POSIX = 2,
    }
}
