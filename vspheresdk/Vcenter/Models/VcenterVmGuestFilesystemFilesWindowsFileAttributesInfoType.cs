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
    public class VcenterVmGuestFilesystemFilesWindowsFileAttributesInfoType 
    {
        /// <summary>
        /// The file is hidden.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hidden", Required = Required.AllowNull)]
        public bool Hidden { get; set; }
        /// <summary>
        /// The file is read-only.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "read_only", Required = Required.AllowNull)]
        public bool ReadOnly { get; set; }
        /// <summary>
        /// The date and time the file was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "created", Required = Required.AllowNull)]
        public DateTime Created { get; set; }
    }
}
