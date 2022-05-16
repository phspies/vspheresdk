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
    public class VcenterNetworkFilterSpecTypeA 
    {
        /// <summary>
        /// Identifiers of networks that can match the filter.
        /// If unset or empty, networks with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Network. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// Names that networks must have to match the filter (see Network.Summary.name).
        /// If unset or empty, networks with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Types that networks must have to match the filter (see Network.Summary.type).
        /// If unset, networks with any type match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public Dictionary<string,VcenterNetworkTypeA> Types { get; set; }
        /// <summary>
        /// Folders that must contain the network for the network to match the filter.
        /// If unset or empty, networks in any folder match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<string> Folders { get; set; }
        /// <summary>
        /// Datacenters that must contain the network for the network to match the filter.
        /// If unset or empty, networks in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
    }
}
