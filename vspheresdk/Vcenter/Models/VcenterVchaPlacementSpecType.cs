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
    public class VcenterVchaPlacementSpecType 
    {
        /// <summary>
        /// The name of the VCHA node to be used for the virtual machine name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The identifier of the folder to deploy the VCHA node to.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Folder:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder", Required = Required.AllowNull)]
        public string Folder { get; set; }
        /// <summary>
        /// The identifier of the host to deploy the VCHA node to.
        /// If unset, see vim.vm.RelocateSpec.host.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem:VCenter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: HostSystem:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// The identifier of the resource pool to deploy the VCHA node to.
        /// If unset, then the active node's resource pool will be used.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool:VCenter. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: ResourcePool:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// The type of the Network object used by the HA network.
        /// If the PlacementSpec.ha-network field is set, then the PlacementSpec.ha-network-type field must be set.
        /// If the PlacementSpec.ha-network field is unset, then the PlacementSpec.ha-network-type field is ignored.
        /// If unset and the PlacementSpec.ha-network field is unset, then the same network present on the Active node virtual
        /// machine is used to deploy the virtual machine with an assumption that the network is present on the destination.
        /// If unset and the PlacementSpec.ha-network field is set, then an error is reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network_type")]
        public VcenterVchaNetworkType HaNetworkType { get; set; }
        /// <summary>
        /// The identifier of the Network object used for the HA network.
        /// If the PlacementSpec.ha-network field is set, then the {#link #haNetworkType} field must be set.
        /// If the PlacementSpec.ha-network field is unset, then the PlacementSpec.ha-network-type field is ignored.
        /// If unset and the PlacementSpec.ha-network-type field is unset, then the same network present on the Active node virtual
        /// machine is used to deploy the virtual machine with an assumption that the network is present on the destination.
        /// 
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Network:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_network")]
        public string? HaNetwork { get; set; }
        /// <summary>
        /// The type of the Network object used by the Management network.
        /// If the PlacementSpec.management-network field is set, then the {#link #managementNetworkType} field must be set.
        /// If the PlacementSpec.management-network field is unset, then the PlacementSpec.management-network-type field is ignored.
        /// If unset and the PlacementSpec.management-network field is unset, then the same network present on the Active node
        /// virtual machine is used to deploy the virtual machine with an assumption that the network is present on the destination.
        /// If unset and the PlacementSpec.management-network field is set, then an error is reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_network_type")]
        public VcenterVchaNetworkType ManagementNetworkType { get; set; }
        /// <summary>
        /// The identifier of the Network object used for the Management network. If the PlacementSpec.management-network field is
        /// set, then the PlacementSpec.management-network-type field must be set.
        /// If the PlacementSpec.management-network field is unset, then the PlacementSpec.management-network-type field is ignored.
        /// If unset and the PlacementSpec.management-network-type field is unset, then the same network present on the Active node
        /// virtual machine is used to deploy the virtual machine with an assumption that the network is present on the destination.
        /// 
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Network:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management_network")]
        public string? ManagementNetwork { get; set; }
        /// <summary>
        /// The storage specification to deploy the VCHA node to.
        /// If unset, see vim.vm.RelocateSpec.datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage")]
        public VcenterVchaDiskSpecType Storage { get; set; }
    }
}
