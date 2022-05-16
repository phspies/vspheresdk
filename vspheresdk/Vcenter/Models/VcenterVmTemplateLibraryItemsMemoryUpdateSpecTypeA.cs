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
    public class VcenterVmTemplateLibraryItemsMemoryUpdateSpecTypeA 
    {
        /// <summary>
        /// Size of a virtual machine's memory in MB.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory")]
        public long? Memory { get; set; }
    }
}
