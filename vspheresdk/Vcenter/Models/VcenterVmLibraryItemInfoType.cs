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
    public class VcenterVmLibraryItemInfoType 
    {
        /// <summary>
        /// Information about the checked out virtual machine.
        /// If unset, the virtual machine is not checked out from a library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_out")]
        public VcenterVmLibraryItemCheckOutInfoType CheckOut { get; set; }
    }
}
