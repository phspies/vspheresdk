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
    public class VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyTypeA 
    {
        /// <summary>
        /// Policy type to be used when creating the deployed virtual machine's disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsDeploySpecDiskStoragePolicyTypeEnumA Type { get; set; }
        /// <summary>
        /// Identifier of the storage policy to use.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public string? Policy { get; set; }
    }
}
