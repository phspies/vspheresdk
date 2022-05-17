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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsGroupType 
    {
        /// <summary>
        /// List of VM Group details.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_groups")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsGroupDetailsType> VmGroups { get; set; }
        /// <summary>
        /// List of HOST Group details.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_groups")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsGroupDetailsType> HostGroups { get; set; }
    }
}
