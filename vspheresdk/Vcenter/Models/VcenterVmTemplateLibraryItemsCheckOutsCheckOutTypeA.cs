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
    public class VcenterVmTemplateLibraryItemsCheckOutsCheckOutTypeA 
    {
        /// <summary>
        /// Specification used to check out the source virtual machine template as a virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public VcenterVmTemplateLibraryItemsCheckOutsCheckOutSpecTypeA Spec { get; set; }
    }
}
