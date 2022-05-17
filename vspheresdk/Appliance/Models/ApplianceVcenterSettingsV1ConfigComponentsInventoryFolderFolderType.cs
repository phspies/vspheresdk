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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderType 
    {
        /// <summary>
        /// List of datastore folders.
        /// If unset. then there are no datastore folders.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderDetailsType> Datastore { get; set; }
        /// <summary>
        /// List of datacenter folders.
        /// If unset. then there are no datacenter folders.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenter")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderDetailsType> Datacenter { get; set; }
        /// <summary>
        /// List of vm folders.
        /// If unset. then there are no vm folders.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderDetailsType> Vm { get; set; }
        /// <summary>
        /// List of network folders.
        /// If unset. then there are no network folders.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderDetailsType> Network { get; set; }
        /// <summary>
        /// List of host folders.
        /// If unset. then there are no host folders.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderDetailsType> Host { get; set; }
    }
}
