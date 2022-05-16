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
    public class VcenterVmTemplateLibraryItemsVmHomeStorageInfoTypeA 
    {
        /// <summary>
        /// Identifier of the datastore where the virtual machine template's configuration and log files are stored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore", Required = Required.AllowNull)]
        public string Datastore { get; set; }
        /// <summary>
        /// Identifier of the storage policy associated with the virtual machine template's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy")]
        public string? StoragePolicy { get; set; }
    }
}
