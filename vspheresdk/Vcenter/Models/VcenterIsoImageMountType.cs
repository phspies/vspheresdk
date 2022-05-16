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
    public class VcenterIsoImageMountType 
    {
        /// <summary>
        /// The identifier of the library item having the ISO image to mount on the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_item", Required = Required.AllowNull)]
        public string LibraryItem { get; set; }
        /// <summary>
        /// The identifier of the virtual machine where the specified ISO image will be mounted.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm", Required = Required.AllowNull)]
        public string Vm { get; set; }
    }
}
