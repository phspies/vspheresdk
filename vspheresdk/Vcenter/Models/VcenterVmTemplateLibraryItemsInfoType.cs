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
    public class VcenterVmTemplateLibraryItemsInfoType 
    {
        /// <summary>
        /// Configured guest operating system of the virtual machine template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_OS", Required = Required.AllowNull)]
        public VcenterVmGuestOsenumType GuestOS { get; set; }
        /// <summary>
        /// CPU configuration of the virtual machine template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsCpuInfoType Cpu { get; set; }
        /// <summary>
        /// Memory configuration of the virtual machine template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsMemoryInfoType Memory { get; set; }
        /// <summary>
        /// Storage information about the virtual machine template's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home_storage", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsVmHomeStorageInfoType VmHomeStorage { get; set; }
        /// <summary>
        /// Storage information about the virtual machine template's virtual disks.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks", Required = Required.AllowNull)]
        public Dictionary<string,VcenterVmTemplateLibraryItemsDiskInfoType> Disks { get; set; }
        /// <summary>
        /// Information about the virtual machine template's virtual ethernet adapters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nics", Required = Required.AllowNull)]
        public Dictionary<string,VcenterVmTemplateLibraryItemsEthernetInfoType> Nics { get; set; }
        /// <summary>
        /// Identifier of the latest virtual machine template contained in the library item. This {@term field} is the managed
        /// object identifier used to identify the virtual machine template in the vSphere Management (SOAP) API.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_template", Required = Required.AllowNull)]
        public string VmTemplate { get; set; }
    }
}
