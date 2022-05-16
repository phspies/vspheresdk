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
    public class VcenterResourcePoolFilterSpecType 
    {
        /// <summary>
        /// Identifiers of resource pools that can match the filter.
        /// If unset or empty, resource pools with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pools")]
        public IList<string> ResourcePools { get; set; }
        /// <summary>
        /// Names that resource pools must have to match the filter (see ResourcePool.Info.name).
        /// If unset or empty, resource pools with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Resource pools that must contain the resource pool for the resource pool to match the filter.
        /// If unset or empty, resource pools in any resource pool match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_resource_pools")]
        public IList<string> ParentResourcePools { get; set; }
        /// <summary>
        /// Datacenters that must contain the resource pool for the resource pool to match the filter.
        /// If unset or empty, resource pools in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
        /// <summary>
        /// Hosts that must contain the resource pool for the resource pool to match the filter.
        /// If unset or empty, resource pools in any host match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// Clusters that must contain the resource pool for the resource pool to match the filter.
        /// If unset or empty, resource pools in any cluster match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<string> Clusters { get; set; }
    }
}
