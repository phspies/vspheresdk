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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryDatacenterDatacenterType 
    {
        /// <summary>
        /// Name of the datacenter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.vcenter.settings.v1.config.components.inventory.datacenter. When operations return a value of this structure
        /// as a result, the field will be an identifier for the resource type:
        /// appliance.vcenter.settings.v1.config.components.inventory.datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Absolute path of the inventory object's parent.
        /// If unset, then inventory object placed in root folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path")]
        public string? ParentPath { get; set; }
        /// <summary>
        /// Permissions defined on the datacenter.
        /// If unset, then no permissions defined on this inventory object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryPermissionType> Permissions { get; set; }
        /// <summary>
        /// Host configuration on the datacenter.
        /// If unset, then no hosts present in the datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "standalone_hosts")]
        public IList<string> StandaloneHosts { get; set; }
    }
}
