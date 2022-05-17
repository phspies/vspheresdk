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
    public class ApplianceLoggingForwardingSetType 
    {
        /// <summary>
        /// The cfgList is a list of Config structure that contains the log message forwarding rules in terms of the host, port,
        /// protocol of the log message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cfg_list", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceLoggingForwardingConfigType> CfgList { get; set; }
    }
}
