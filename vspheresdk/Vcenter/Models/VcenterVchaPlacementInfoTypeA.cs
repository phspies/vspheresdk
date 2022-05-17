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
    public class VcenterVchaPlacementInfoTypeA 
    {
        /// <summary>
        /// The hostname of the vCenter server that is managing the VCHA node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_vcenter_name", Required = Required.AllowNull)]
        public string ManagementVcenterName { get; set; }
        /// <summary>
        /// The unique identifier of the vCenter server that is managing the VCHA node.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_vcenter_server_guid")]
        public string? ManagementVcenterServerGuid { get; set; }
        /// <summary>
        /// The virtual machine name of the VCHA node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_name", Required = Required.AllowNull)]
        public string VmName { get; set; }
        /// <summary>
        /// The identifier of the datacenter of the VCHA node.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datacenter:VCenter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: Datacenter:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenter", Required = Required.AllowNull)]
        public string Datacenter { get; set; }
        /// <summary>
        /// The name of the datacenter of the VCHA node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenter_name", Required = Required.AllowNull)]
        public string DatacenterName { get; set; }
        /// <summary>
        /// The identifier of the host of the VCHA node.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem:VCenter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: HostSystem:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// The name of the host of the VCHA node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_name", Required = Required.AllowNull)]
        public string HostName { get; set; }
        /// <summary>
        /// The identifier of the cluster of which PlacementInfo.host is member.
        /// If unset, PlacementInfo.host is a standalone host.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource:VCenter. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: ClusterComputeResource:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// The name of the cluster of which PlacementInfo.host is member.
        /// If unset, PlacementInfo.host is a standalone host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name")]
        public string? ClusterName { get; set; }
        /// <summary>
        /// The identifier of the Network object used for the HA network.
        /// If unset, the information is currently unavailable or the haNetwork is not configured.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Network:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network")]
        public string? HaNetwork { get; set; }
        /// <summary>
        /// The name of the Network object used for the HA network.
        /// If unset, the information is currently unavailable or the haNetwork is not configured.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network_name")]
        public string? HaNetworkName { get; set; }
        /// <summary>
        /// The type of the Network object used for the HA network.
        /// If unset, the information is currently unavailable or the haNetwork is not configured.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network_type")]
        public VcenterVchaNetworkTypeEnumA HaNetworkType { get; set; }
        /// <summary>
        /// The identifier of the Network object used for the Management network.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Network:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_network", Required = Required.AllowNull)]
        public string ManagementNetwork { get; set; }
        /// <summary>
        /// The name of the Network object used for the Management network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_network_name", Required = Required.AllowNull)]
        public string ManagementNetworkName { get; set; }
        /// <summary>
        /// The type of the Network object used for the Management network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_network_type", Required = Required.AllowNull)]
        public VcenterVchaNetworkTypeEnumA ManagementNetworkType { get; set; }
        /// <summary>
        /// The storage information of the VCHA node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage", Required = Required.AllowNull)]
        public VcenterVchaDiskInfoTypeA Storage { get; set; }
        /// <summary>
        /// BIOS UUID for the node.
        /// If unset, the information is currently unavailable.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios_uuid")]
        public string? BiosUuid { get; set; }
    }
}
