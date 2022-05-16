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
    public class VcenterVmTemplateLibraryItemsDiskUpdateSpecTypeA 
    {
        /// <summary>
        /// Updated capacity of the virtual disk backing in bytes. This value has to be larger than the original capacity of the
        /// disk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity", Required = Required.AllowNull)]
        public long Capacity { get; set; }
    }
}
