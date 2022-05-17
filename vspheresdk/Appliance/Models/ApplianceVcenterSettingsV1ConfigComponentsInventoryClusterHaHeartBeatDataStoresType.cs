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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaHeartBeatDataStoresType 
    {
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "heartbeat_datastore_policy", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaHeartBeatDataStoresHbdatastoreCandidateType HeartbeatDatastorePolicy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastores")]
        public IList<string> Datastores { get; set; }
    }
}
