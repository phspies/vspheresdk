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
    public class VcenterVmGuestFilesystemFilesPosixFileAttributesInfoType 
    {
        /// <summary>
        /// The owner ID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner", Required = Required.AllowNull)]
        public long Owner { get; set; }
        /// <summary>
        /// The group ID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group", Required = Required.AllowNull)]
        public long Group { get; set; }
        /// <summary>
        /// The file permissions in chmod(2) format. This field is presented as octal.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions", Required = Required.AllowNull)]
        public string Permissions { get; set; }
    }
}
