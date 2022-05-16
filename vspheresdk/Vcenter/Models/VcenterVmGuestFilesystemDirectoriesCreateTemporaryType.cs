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
    public class VcenterVmGuestFilesystemDirectoriesCreateTemporaryType 
    {
        /// <summary>
        /// The guest authentication data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The prefix to be given to the new temporary directory.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public string Prefix { get; set; }
        /// <summary>
        /// The suffix to be given to the new temporary directory.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "suffix", Required = Required.AllowNull)]
        public string Suffix { get; set; }
        /// <summary>
        /// The complete path to the directory in which to create the new directory.
        /// Directory If unset a guest-specific default will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path")]
        public string? ParentPath { get; set; }
    }
}
