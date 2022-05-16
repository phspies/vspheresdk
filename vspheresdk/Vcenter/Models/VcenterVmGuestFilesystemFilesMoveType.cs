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
    public class VcenterVmGuestFilesystemFilesMoveType 
    {
        /// <summary>
        /// The guest authentication data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The complete path to the original file or symbolic link to be moved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// The complete path to the new file. It cannot be a path to an existing directory.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_path", Required = Required.AllowNull)]
        public string NewPath { get; set; }
        /// <summary>
        /// If true, the destination file is overwritten.
        /// If unset, the destination file is not overwritten.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwrite")]
        public bool? Overwrite { get; set; }
    }
}
