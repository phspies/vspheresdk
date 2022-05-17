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
    public class VcenterFolderSummaryType 
    {
        /// <summary>
        /// Identifier of the folder.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder", Required = Required.AllowNull)]
        public string Folder { get; set; }
        /// <summary>
        /// Name of the vCenter Server folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Type (Type) of the vCenter Server folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterFolderTypeEnum Type { get; set; }
    }
}
