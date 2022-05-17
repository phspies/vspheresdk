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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreStoragePodType 
    {
        /// <summary>
        /// Identifier of the Storage Pod.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.vcenter.settings.v1.config.components.inventory.storagepod. When operations return a value of this structure
        /// as a result, the field will be an identifier for the resource type:
        /// appliance.vcenter.settings.v1.config.components.inventory.storagepod.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Absolute path of the inventory object's parent.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent_path", Required = Required.AllowNull)]
        public string ParentPath { get; set; }
        /// <summary>
        /// Storage DRS related attributes of the Storage Pod.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod_storage_drs_entry", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastorePodStorageDrsEntryType PodStorageDrsEntry { get; set; }
        /// <summary>
        /// Permissions defined on the Storage Pod.
        /// If unset, then no permissions defined on this inventory object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryPermissionType> Permissions { get; set; }
    }
}
