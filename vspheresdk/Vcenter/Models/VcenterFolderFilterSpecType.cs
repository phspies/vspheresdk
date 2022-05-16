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
    public class VcenterFolderFilterSpecType 
    {
        /// <summary>
        /// Identifiers of folders that can match the filter.
        /// If unset or empty, folders with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<string> Folders { get; set; }
        /// <summary>
        /// Names that folders must have to match the filter (see Folder.Summary.name).
        /// If unset or empty, folders with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Type that folders must have to match the filter (see Folder.Summary.type).
        /// If unset, folders with any type match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterFolderType Type { get; set; }
        /// <summary>
        /// Folders that must contain the folder for the folder to match the filter.
        /// If unset or empty, folder in any folder match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_folders")]
        public IList<string> ParentFolders { get; set; }
        /// <summary>
        /// Datacenters that must contain the folder for the folder to match the filter.
        /// If unset or empty, folder in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
    }
}
