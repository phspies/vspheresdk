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
    public class VcenterVmTemplateLibraryItemsCheckOutsCheckOutSpecType 
    {
        /// <summary>
        /// Name of the virtual machine to check out of the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Information used to place the checked out virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmTemplateLibraryItemsCheckOutsPlacementSpecType Placement { get; set; }
        /// <summary>
        /// Specifies whether the virtual machine should be powered on after check out.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "powered_on")]
        public bool? PoweredOn { get; set; }
    }
}
