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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreSummaryType 
    {
        /// <summary>
        /// Maximum capacity of this datastore, in bytes. This value is updated periodically by the server. It can be explicitly
        /// refreshed with the Refresh operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }
        /// <summary>
        /// More than one host in the datacenter has been configured with access to the datastore. This is only provided by
        /// VirtualCenter.
        /// If unset, then the datastore not configured with access from more than one host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiple_host_access")]
        public bool? MultipleHostAccess { get; set; }
        /// <summary>
        /// Type of file system volume, such as VMFS or NFS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// The current maintenance mode state of the datastore.
        /// If unset, then the current maintenance mode state of the datastore is set to normal.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreMaintenanceModeStateType MaintenanceMode { get; set; }
    }
}
