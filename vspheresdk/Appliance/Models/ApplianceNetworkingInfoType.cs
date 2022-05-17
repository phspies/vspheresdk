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
    public class ApplianceNetworkingInfoType 
    {
        /// <summary>
        /// DNS configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns", Required = Required.AllowNull)]
        public ApplianceNetworkingDnsinfoType Dns { get; set; }
        /// <summary>
        /// Interface configuration as a key-value map where key is a network interface name, for example, "nic0".
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: appliance.networking.interfaces. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: appliance.networking.interfaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interfaces", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceNetworkingInterfacesInterfaceInfoType> Interfaces { get; set; }
    }
}
