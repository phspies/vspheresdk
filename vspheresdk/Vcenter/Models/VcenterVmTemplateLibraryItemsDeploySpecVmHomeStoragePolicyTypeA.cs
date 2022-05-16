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
    public class VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicyTypeA 
    {
        /// <summary>
        /// Policy type to be used when creating the deployed virtual machine's configuration and log files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicyTypeA Type { get; set; }
        /// <summary>
        /// Identifier for the storage policy to use.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public string? Policy { get; set; }
    }
}
