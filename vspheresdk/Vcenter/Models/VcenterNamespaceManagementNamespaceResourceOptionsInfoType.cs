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
    public class VcenterNamespaceManagementNamespaceResourceOptionsInfoType 
    {
        /// <summary>
        /// Identifier of the structure used to set resource quotas on the namespace. See vcenter.namespaces.Instances#create and
        /// vcenter.namespaces.Instances#set.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vapi.structure. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: vapi.structure.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "create_resource_quota_type", Required = Required.AllowNull)]
        public string CreateResourceQuotaType { get; set; }
        /// <summary>
        /// Identifier of the structure used to update resource quotas on the namespace. See vcenter.namespaces.Instances#update.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vapi.structure. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: vapi.structure.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_resource_quota_type", Required = Required.AllowNull)]
        public string UpdateResourceQuotaType { get; set; }
    }
}
