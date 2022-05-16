using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVmGuestFilesystemFilesFileAttributesInfoType 
    {
        /// <summary>
        /// The date and time the file was last modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified", Required = Required.AllowNull)]
        public DateTime LastModified { get; set; }
        /// <summary>
        /// The date and time the file was last accessed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_accessed", Required = Required.AllowNull)]
        public DateTime LastAccessed { get; set; }
        /// <summary>
        /// The target for the file if it's a symbolic link. This is currently only set for Posix guest operating systems, but may
        /// be supported in the future on Windows guest operating systems that support symbolic links.
        /// Set if the file is a symbolic link.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "symlink_target")]
        public string? SymlinkTarget { get; set; }
        /// <summary>
        /// The type of guest filesystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesystem_family", Required = Required.AllowNull)]
        public VcenterVmGuestFilesystemFilesFilesystemFamilyType FilesystemFamily { get; set; }
        /// <summary>
        /// Windows-specific file information.
        /// This field is optional and it is only relevant when the value of Files.FileAttributesInfo.filesystem-family is WINDOWS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "win_attributes")]
        public VcenterVmGuestFilesystemFilesWindowsFileAttributesInfoType WinAttributes { get; set; }
        /// <summary>
        /// Posix-specific file information.
        /// This field is optional and it is only relevant when the value of Files.FileAttributesInfo.filesystem-family is POSIX.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "posix_attributes")]
        public VcenterVmGuestFilesystemFilesPosixFileAttributesInfoType PosixAttributes { get; set; }
    }
}
