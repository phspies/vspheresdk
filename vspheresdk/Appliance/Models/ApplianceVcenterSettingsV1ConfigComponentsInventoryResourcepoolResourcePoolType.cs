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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourcePoolType 
    {
        /// <summary>
        /// Name of the vCenter Server resource pool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Parent name for the resource pool.
        /// If unset, then inventory object placed in root folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path")]
        public string? ParentPath { get; set; }
        /// <summary>
        /// Identifiers of the child resource pools contained in this resource pool.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "child_resource_pools")]
        public IList<string> ChildResourcePools { get; set; }
        /// <summary>
        /// Identifiers of the virtual machines contained in this resource pool.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm")]
        public IList<string> Vm { get; set; }
        /// <summary>
        /// Summary of the Resource pools.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourcePoolSummaryType Config { get; set; }
        /// <summary>
        /// Permission on the resourcepool.
        /// If unset, then no permissions defined on this inventory object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryPermissionType> Permissions { get; set; }
    }
}
