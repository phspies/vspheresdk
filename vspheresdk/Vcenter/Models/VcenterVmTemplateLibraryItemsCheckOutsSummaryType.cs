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
    public class VcenterVmTemplateLibraryItemsCheckOutsSummaryType 
    {
        /// <summary>
        /// Identifier of the checked out virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm", Required = Required.AllowNull)]
        public string Vm { get; set; }
    }
}
