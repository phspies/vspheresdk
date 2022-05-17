using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterClusterConfigInfoType 
    {
        /// <summary>
        /// Name of the cluster
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Absolute path from root folder to cluster's parent.
        /// If unset, then inventory object placed in root folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path")]
        public string? ParentPath { get; set; }
        /// <summary>
        /// List of vsphere HA configurations for clusters.
        /// If unset, then HA configurations are not set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaVsphereHatype Ha { get; set; }
        /// <summary>
        /// Settings for HA vm overrides.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_vm_overrides")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaHaVmOverridesType> HaVmOverrides { get; set; }
        /// <summary>
        /// Cluster-wide configuration of the vSphere DRS service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "drs")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsConfigType Drs { get; set; }
        /// <summary>
        /// List of virtual machine configurations for the vSphere DRS service. Each entry applies to one virtual machine. If a
        /// virtual machine is not specified in this list, the service uses the default settings for that virtual machine.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "drs_vm_overrides")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsVmOverridesType> DrsVmOverrides { get; set; }
        /// <summary>
        /// Cluster-wide rules.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsRuleType Rules { get; set; }
        /// <summary>
        /// Cluster-wide groups.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsGroupType Groups { get; set; }
        /// <summary>
        /// Cluster-wide configuration of the vSphere InfraUpdateHA service.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proactive_ha")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsProactiveHaconfigType ProactiveHa { get; set; }
        /// <summary>
        /// Host configuration on the datacenter.
        /// If unset, then no hosts present in the datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// Permissions defined on the cluster.
        /// If unset, then no permissions defined on this inventory object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryPermissionType> Permissions { get; set; }
        /// <summary>
        /// List of Resource pools.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pools")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourcePoolType> ResourcePools { get; set; }
    }
}
