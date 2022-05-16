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
    public class VcenterVmGuestFilesystemFilesWindowsFileAttributesUpdateSpecType 
    {
        /// <summary>
        /// The file is hidden.
        /// If {term unset} the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }
        /// <summary>
        /// The file is read-only.
        /// If {term unset} the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "read_only")]
        public bool? ReadOnly { get; set; }
    }
}
