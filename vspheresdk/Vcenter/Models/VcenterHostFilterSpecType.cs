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
    public class VcenterHostFilterSpecType 
    {
        /// <summary>
        /// Identifiers of hosts that can match the filter.
        /// If unset or empty, hosts with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// Names that hosts must have to match the filter (see Host.Summary.name).
        /// If unset or empty, hosts with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Folders that must contain the hosts for the hosts to match the filter.
        /// If unset or empty, hosts in any folder match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<string> Folders { get; set; }
        /// <summary>
        /// Datacenters that must contain the hosts for the hosts to match the filter.
        /// If unset or empty, hosts in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
        /// <summary>
        /// If true, only hosts that are not part of a cluster can match the filter, and if false, only hosts that are are part of a
        /// cluster can match the filter.
        /// If unset Hosts can match filter independent of whether they are part of a cluster or not. If this field is true and
        /// Host.FilterSpec.clusters os not empty, no hosts will match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "standalone")]
        public bool? Standalone { get; set; }
        /// <summary>
        /// Clusters that must contain the hosts for the hosts to match the filter.
        /// If unset or empty, hosts in any cluster and hosts that are not in a cluster match the filter. If this field is not empty
        /// and Host.FilterSpec.standalone is true, no hosts will match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<string> Clusters { get; set; }
        /// <summary>
        /// Connection states that a host must be in to match the filter (see Host.Summary.connection-state.
        /// If unset or empty, hosts in any connection state match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_states")]
        public Dictionary<string,VcenterHostConnectionStateEnumType> ConnectionStates { get; set; }
    }
}
