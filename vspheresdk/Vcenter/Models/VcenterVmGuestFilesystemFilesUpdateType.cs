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
    public class VcenterVmGuestFilesystemFilesUpdateType 
    {
        /// <summary>
        /// The guest authentication data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The complete path to the file or directory to be changed in the guest. If the file points to an symbolic link, then the
        /// attributes of the target file are changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// Specifies the different file attributes of the guest file to be changed. See Files.FileAttributesUpdateSpec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_attributes", Required = Required.AllowNull)]
        public VcenterVmGuestFilesystemFilesFileAttributesUpdateSpecType FileAttributes { get; set; }
    }
}
