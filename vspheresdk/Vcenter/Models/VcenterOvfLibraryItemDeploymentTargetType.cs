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
    public class VcenterOvfLibraryItemDeploymentTargetType 
    {
        /// <summary>
        /// Identifier of the resource pool to which the virtual machine or virtual appliance should be attached.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool_id", Required = Required.AllowNull)]
        public string ResourcePoolId { get; set; }
        /// <summary>
        /// Identifier of the target host on which the virtual machine or virtual appliance will run. The target host must be a
        /// member of the cluster that contains the resource pool identified by {@link #resourcePoolId}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Identifier of the vCenter folder that should contain the virtual machine or virtual appliance. The folder must be
        /// virtual machine folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder_id")]
        public string? FolderId { get; set; }
    }
}
