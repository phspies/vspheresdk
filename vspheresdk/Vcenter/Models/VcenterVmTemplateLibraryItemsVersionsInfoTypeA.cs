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
    public class VcenterVmTemplateLibraryItemsVersionsInfoTypeA 
    {
        /// <summary>
        /// Identifier of the virtual machine template associated with the library item version. This {@term field} is the managed
        /// object identifier used to identify the virtual machine template in the vSphere Management (SOAP) API.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_template", Required = Required.AllowNull)]
        public string VmTemplate { get; set; }
    }
}
