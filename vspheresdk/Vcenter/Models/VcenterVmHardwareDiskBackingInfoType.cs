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
    public class VcenterVmHardwareDiskBackingInfoType 
    {
        /// <summary>
        /// Backing type for the virtual disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareDiskBackingType Type { get; set; }
        /// <summary>
        /// Path of the VMDK file backing the virtual disk.
        /// This field is optional and it is only relevant when the value of Disk.BackingInfo.type is VMDK_FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vmdk_file")]
        public string? VmdkFile { get; set; }
    }
}
