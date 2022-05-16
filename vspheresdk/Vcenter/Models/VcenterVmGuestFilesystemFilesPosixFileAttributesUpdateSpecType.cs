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
    public class VcenterVmGuestFilesystemFilesPosixFileAttributesUpdateSpecType 
    {
        /// <summary>
        /// The owner ID.
        /// If unset the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_id")]
        public long? OwnerId { get; set; }
        /// <summary>
        /// The group ID.
        /// If unset the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public long? GroupId { get; set; }
        /// <summary>
        /// The file permissions in chmod(2) format. This field is interpreted as octal.
        /// If unset the value will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public string? Permissions { get; set; }
    }
}
