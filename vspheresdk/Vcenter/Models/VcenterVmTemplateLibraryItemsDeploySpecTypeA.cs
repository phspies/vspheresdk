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
    public class VcenterVmTemplateLibraryItemsDeploySpecTypeA 
    {
        /// <summary>
        /// Name of the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Storage location for the deployed virtual machine's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_home_storage")]
        public VcenterVmTemplateLibraryItemsDeploySpecVmHomeStorageTypeA VmHomeStorage { get; set; }
        /// <summary>
        /// Storage specification for the deployed virtual machine's disks.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disk_storage")]
        public VcenterVmTemplateLibraryItemsDeploySpecDiskStorageTypeA DiskStorage { get; set; }
        /// <summary>
        /// Storage specification for individual disks in the deployed virtual machine. This is specified as a mapping between disk
        /// identifiers in the source virtual machine template contained in the library item and their storage specifications.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disk_storage_overrides")]
        public IList<object> DiskStorageOverrides { get; set; }
        /// <summary>
        /// Information used to place the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmTemplateLibraryItemsDeployPlacementSpecTypeA Placement { get; set; }
        /// <summary>
        /// Specifies whether the deployed virtual machine should be powered on after deployment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "powered_on")]
        public bool? PoweredOn { get; set; }
        /// <summary>
        /// Guest customization spec to apply to the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_customization")]
        public VcenterVmTemplateLibraryItemsGuestCustomizationSpecTypeA GuestCustomization { get; set; }
        /// <summary>
        /// Hardware customization spec which specifies updates to the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware_customization")]
        public VcenterVmTemplateLibraryItemsHardwareCustomizationSpecTypeA HardwareCustomization { get; set; }
    }
}
