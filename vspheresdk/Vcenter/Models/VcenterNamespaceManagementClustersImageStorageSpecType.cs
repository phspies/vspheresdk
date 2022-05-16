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
    public class VcenterNamespaceManagementClustersImageStorageSpecType 
    {
        /// <summary>
        /// Identifier of the storage policy.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy", Required = Required.AllowNull)]
        public string StoragePolicy { get; set; }
    }
}
