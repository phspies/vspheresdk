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
    public class VcenterVmTemplateLibraryItemsCreateType 
    {
        /// <summary>
        /// Identifier of the source virtual machine to create the library item from.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_vm", Required = Required.AllowNull)]
        public string SourceVm { get; set; }
        /// <summary>
        /// Name of the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Identifier of the library in which the new library item should be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library", Required = Required.AllowNull)]
        public string Library { get; set; }
        /// <summary>
        /// Storage location for the virtual machine template's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home_storage")]
        public VcenterVmTemplateLibraryItemsCreateSpecVmHomeStorageType VmHomeStorage { get; set; }
        /// <summary>
        /// Storage specification for the virtual machine template's disks.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disk_storage")]
        public VcenterVmTemplateLibraryItemsCreateSpecDiskStorageType DiskStorage { get; set; }
        /// <summary>
        /// Storage specification for individual disks in the virtual machine template. This is specified as a mapping between disk
        /// identifiers in the source virtual machine and their respective storage specifications.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disk_storage_overrides")]
        public Dictionary<string,VcenterVmTemplateLibraryItemsCreateSpecDiskStorageType>? DiskStorageOverrides { get; set; }
        /// <summary>
        /// Information used to place the virtual machine template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmTemplateLibraryItemsCreatePlacementSpecType Placement { get; set; }
    }
}
