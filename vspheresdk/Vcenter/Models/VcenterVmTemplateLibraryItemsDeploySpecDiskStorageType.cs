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
    public class VcenterVmTemplateLibraryItemsDeploySpecDiskStorageType 
    {
        /// <summary>
        /// Identifier for the datastore associated the deployed virtual machine's disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
        /// <summary>
        /// Storage policy for the deployed virtual machine's disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy")]
        public VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyType StoragePolicy { get; set; }
    }
}
