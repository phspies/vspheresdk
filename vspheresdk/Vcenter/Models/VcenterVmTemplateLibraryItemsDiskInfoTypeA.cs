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
    public class VcenterVmTemplateLibraryItemsDiskInfoTypeA 
    {
        /// <summary>
        /// Capacity of the virtual disk in bytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }
        /// <summary>
        /// Disk storage related information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disk_storage", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsDiskStorageInfoTypeA DiskStorage { get; set; }
    }
}
