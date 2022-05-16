using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterHostSummaryTypeA 
    {
        /// <summary>
        /// Identifier of the host.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Name of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Connection status of the host
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_state", Required = Required.AllowNull)]
        public VcenterHostConnectionStateTypeA ConnectionState { get; set; }
        /// <summary>
        /// Power state of the host
        /// This field is optional and it is only relevant when the value of Host.Summary.connection-state is CONNECTED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "power_state")]
        public VcenterHostPowerStateTypeA PowerState { get; set; }
    }
}
