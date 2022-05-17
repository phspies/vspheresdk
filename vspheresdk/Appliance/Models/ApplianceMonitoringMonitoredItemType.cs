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
    public class ApplianceMonitoringMonitoredItemType 
    {
        /// <summary>
        /// monitored item ID Ex: CPU, MEMORY
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.monitoring. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: appliance.monitoring.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// monitored item name Ex: "Network write speed"
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Y-axis label EX: "Mbps", "%"
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "units", Required = Required.AllowNull)]
        public string Units { get; set; }
        /// <summary>
        /// category Ex: network, storage etc
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public string Category { get; set; }
        /// <summary>
        /// instance name Ex: eth0
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "instance", Required = Required.AllowNull)]
        public string Instance { get; set; }
        /// <summary>
        /// monitored item description Ex: applmgmt.mon.descr.net.rx.packetRate.eth0
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
    }
}
