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
    public class VcenterVmGuestFilesystemDirectoriesCreateType 
    {
        /// <summary>
        /// The guest authentication data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The complete path to the directory to be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// Whether any parent directories should be created. If any failure occurs, some parent directories could be left behind.
        /// If unset parent directories are not created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "create_parents")]
        public bool? CreateParents { get; set; }
    }
}
