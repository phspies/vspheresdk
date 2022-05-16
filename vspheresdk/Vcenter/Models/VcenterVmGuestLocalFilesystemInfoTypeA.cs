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
    public class VcenterVmGuestLocalFilesystemInfoTypeA 
    {
        /// <summary>
        /// Total capacity of the file system, in bytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity", Required = Required.AllowNull)]
        public long Capacity { get; set; }
        /// <summary>
        /// Free space on the file system, in bytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "free_space", Required = Required.AllowNull)]
        public long FreeSpace { get; set; }
        /// <summary>
        /// Filesystem type, if known. For example, ext3 or NTFS.
        /// set if VMware Tools reports a value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesystem")]
        public string? Filesystem { get; set; }
        /// <summary>
        /// VirtualDisks backing the guest partition, if known.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mappings")]
        public Dictionary<string,VcenterVmGuestLocalFilesystemVirtualDiskMappingTypeA> Mappings { get; set; }
    }
}
