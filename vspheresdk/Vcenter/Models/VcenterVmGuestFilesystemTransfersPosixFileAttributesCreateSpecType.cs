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
    public class VcenterVmGuestFilesystemTransfersPosixFileAttributesCreateSpecType 
    {
        /// <summary>
        /// The owner ID. If this property is not specified when passing a Transfers.PosixFileAttributesCreateSpec object to
        /// Transfers.create, the default value will be the owner Id of the user who invoked the file transfer operation.
        /// Defaults to uid of user invoking the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner_id")]
        public long? OwnerId { get; set; }
        /// <summary>
        /// The group ID. If this property is not specified when passing a Transfers.PosixFileAttributesCreateSpec object to
        /// Transfers.create, the default value will be the group Id of the user who invoked the file transfer operation.
        /// Defaults to gid of user invoking the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public long? GroupId { get; set; }
        /// <summary>
        /// The file permissions in chmod(2) format. If this property is not specified when passing a
        /// Transfers.PosixFileAttributesCreateSpec object to Transfers.create, the file will be created with 0644 permissions. This
        /// field is interpreted as octal.
        /// Defaults to 0644.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public string? Permissions { get; set; }
    }
}
