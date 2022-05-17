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
    public class VcenterTopologyNodesFilterSpecTypeA 
    {
        /// <summary>
        /// Types of the appliance that a vCenter and Platform Services Controller node must be to match the filter (see
        /// Nodes.ApplianceType.
        /// If unset or empty, node of any ApplianceType match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public Dictionary<string,VcenterTopologyNodesApplianceTypeEnumA> Types { get; set; }
    }
}
