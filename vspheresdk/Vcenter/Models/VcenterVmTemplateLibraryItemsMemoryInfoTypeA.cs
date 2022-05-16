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
    public class VcenterVmTemplateLibraryItemsMemoryInfoTypeA 
    {
        /// <summary>
        /// Memory size in mebibytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size_MiB", Required = Required.AllowNull)]
        public long SizeMiB { get; set; }
    }
}
