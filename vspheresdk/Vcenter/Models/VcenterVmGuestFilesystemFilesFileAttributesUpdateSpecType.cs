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
    public class VcenterVmGuestFilesystemFilesFileAttributesUpdateSpecType 
    {
        /// <summary>
        /// The date and time the file was last modified.
        /// If unset the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified")]
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// The date and time the file was last accessed.
        /// If unset the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_accessed")]
        public DateTime? LastAccessed { get; set; }
        /// <summary>
        /// Windows-specific file update information.
        /// Set if the guest operating system is Windows.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "windows")]
        public VcenterVmGuestFilesystemFilesWindowsFileAttributesUpdateSpecType Windows { get; set; }
        /// <summary>
        /// Posix-specific file update information.
        /// Set if the guest operating system is Posix.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "posix")]
        public VcenterVmGuestFilesystemFilesPosixFileAttributesUpdateSpecType Posix { get; set; }
    }
}
