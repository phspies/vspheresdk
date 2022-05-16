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
    public class VcenterVmGuestFilesystemTransfersCreateSpecType 
    {
        /// <summary>
        /// The complete destination path in the guest to transfer the file to or from the client. It cannot be a path to a
        /// directory or a symbolic link.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// Details about the file to be transferred into the guest.
        /// Must be set if the file is being transferred to the guest. Must not be set if the file is being transferred from the
        /// guest.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public VcenterVmGuestFilesystemTransfersFileCreationAttributesType Attributes { get; set; }
    }
}
