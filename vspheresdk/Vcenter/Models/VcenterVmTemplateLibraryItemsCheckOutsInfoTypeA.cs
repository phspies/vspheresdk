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
    public class VcenterVmTemplateLibraryItemsCheckOutsInfoTypeA 
    {
        /// <summary>
        /// Date and time when the virtual machine was checked out.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time", Required = Required.AllowNull)]
        public DateTime Time { get; set; }
        /// <summary>
        /// Name of the user who checked out the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user", Required = Required.AllowNull)]
        public string User { get; set; }
    }
}
