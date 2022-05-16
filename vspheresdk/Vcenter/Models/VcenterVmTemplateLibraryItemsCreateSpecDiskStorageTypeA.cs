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
    public class VcenterVmTemplateLibraryItemsCreateSpecDiskStorageTypeA 
    {
        /// <summary>
        /// Identifier for the datastore associated with a virtual machine template's disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
        /// <summary>
        /// Storage policy for a virtual machine template's disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy")]
        public VcenterVmTemplateLibraryItemsCreateSpecDiskStoragePolicyTypeA StoragePolicy { get; set; }
    }
}
