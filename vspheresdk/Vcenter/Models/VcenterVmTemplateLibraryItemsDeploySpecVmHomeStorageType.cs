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
    public class VcenterVmTemplateLibraryItemsDeploySpecVmHomeStorageType 
    {
        /// <summary>
        /// Identifier of the datastore for the deployed virtual machine's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
        /// <summary>
        /// Storage policy for the deployed virtual machine's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy")]
        public VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicyType StoragePolicy { get; set; }
    }
}
