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
    public class VcenterVmGuestFilesystemTransfersWindowsFileAttributesCreateSpecType 
    {
        /// <summary>
        /// The file is hidden.
        /// If unset the file will not be hidden.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hidden")]
        public bool? Hidden { get; set; }
        /// <summary>
        /// The file is read-only.
        /// If unset the file will be writeable.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "read_only")]
        public bool? ReadOnly { get; set; }
    }
}
