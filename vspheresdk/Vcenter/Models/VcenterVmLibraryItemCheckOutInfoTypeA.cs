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
    public class VcenterVmLibraryItemCheckOutInfoTypeA 
    {
        /// <summary>
        /// Identifier of the library item that the virtual machine is checked out from.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// content.library.Item. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: content.library.Item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_item", Required = Required.AllowNull)]
        public string LibraryItem { get; set; }
    }
}
