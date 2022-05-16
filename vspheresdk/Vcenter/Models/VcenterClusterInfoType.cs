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
    public class VcenterClusterInfoType 
    {
        /// <summary>
        /// The name of the cluster
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Identifier of the root resource pool of the cluster
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool", Required = Required.AllowNull)]
        public string ResourcePool { get; set; }
    }
}
