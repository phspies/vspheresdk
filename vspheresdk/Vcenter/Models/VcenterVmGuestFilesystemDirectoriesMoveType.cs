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
    public class VcenterVmGuestFilesystemDirectoriesMoveType 
    {
        /// <summary>
        /// The guest authentication data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The complete path to the directory to be moved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// The complete path to where the directory is moved or its new name. It cannot be a path to an existing directory or an
        /// existing file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_path", Required = Required.AllowNull)]
        public string NewPath { get; set; }
    }
}
