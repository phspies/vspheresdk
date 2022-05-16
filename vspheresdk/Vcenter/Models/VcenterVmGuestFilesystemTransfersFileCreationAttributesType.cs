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
    public class VcenterVmGuestFilesystemTransfersFileCreationAttributesType 
    {
        /// <summary>
        /// The size in bytes of the file to be transferred into the guest.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
        /// <summary>
        /// Whether an existing file should be overwritten.
        /// If unset any existing file will not be overwritten.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwrite")]
        public bool? Overwrite { get; set; }
        /// <summary>
        /// The date and time the file was last modified.
        /// If unset the value will be the time when the file is transferred into the guest.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// The date and time the file was last accessed.
        /// If unset the value will be the time when the file is transferred into the guest.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_accessed")]
        public DateTime? LastAccessed { get; set; }
        /// <summary>
        /// Windows-specific file creation information.
        /// If unset, the behavior is equivalent to a Transfers.WindowsFileAttributesCreateSpec with all fields unset which means
        /// the defaults are used. May only be set if the guest operating system is Windows.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "windows")]
        public VcenterVmGuestFilesystemTransfersWindowsFileAttributesCreateSpecType Windows { get; set; }
        /// <summary>
        /// Posix-specific file creation information.
        /// If unset, the behavior is equivalent to a Transfers.PosixFileAttributesCreateSpec with all fields unset which means the
        /// defaults are used. May only be set if the guest operating system is Posix.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "posix")]
        public VcenterVmGuestFilesystemTransfersPosixFileAttributesCreateSpecType Posix { get; set; }
    }
}
