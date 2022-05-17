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
    public class VcenterVchaClusterActiveSpecTypeA 
    {
        /// <summary>
        /// The type of the Network object used by the HA network.
        /// If the Cluster.ActiveSpec.ha-network field is set, then the Cluster.ActiveSpec.ha-network-type field must be set.
        /// If the Cluster.ActiveSpec.ha-network field is unset, then the Cluster.ActiveSpec.ha-network-type field is ignored.
        /// If unset and the Cluster.ActiveSpec.ha-network field is unset, then the second NIC is assumed to be already configured.
        /// If unset and the Cluster.ActiveSpec.ha-network field is set, then an error is reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network_type")]
        public VcenterVchaNetworkTypeEnumA HaNetworkType { get; set; }
        /// <summary>
        /// The identifier of the Network object used for the HA network.
        /// If the Cluster.ActiveSpec.ha-network field is set, then the Cluster.ActiveSpec.ha-network-type field must be set.
        /// If the Cluster.ActiveSpec.ha-network field is unset, then the Cluster.ActiveSpec.ha-network-type field is ignored.
        /// If unset and the Cluster.ActiveSpec.ha-network-type field is unset, then the second NIC is assumed to be already
        /// configured.
        /// If unset and the Cluster.ActiveSpec.ha-network field is set, then an error is reported.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Network:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network")]
        public string? HaNetwork { get; set; }
        /// <summary>
        /// IP specification for the HA network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_ip", Required = Required.AllowNull)]
        public VcenterVchaIpSpecTypeA HaIp { get; set; }
    }
}
