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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryInventoryManagementType 
    {
        /// <summary>
        /// List of Folders.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryFolderFolderType Folders { get; set; }
        /// <summary>
        /// List of Datacenters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryDatacenterDatacenterType> Datacenters { get; set; }
        /// <summary>
        /// List of ClusterConfigurations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterClusterConfigInfoType> Clusters { get; set; }
        /// <summary>
        /// List of Datastore Clusters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_pods")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreStoragePodType> StoragePods { get; set; }
        /// <summary>
        /// List of Datastores.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastores")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreDatastoreType> Datastores { get; set; }
        /// <summary>
        /// List of standard networks.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryNetworkNetworkType> Networks { get; set; }
        /// <summary>
        /// List of Hosts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryHostHostConfigType> Hosts { get; set; }
    }
}
