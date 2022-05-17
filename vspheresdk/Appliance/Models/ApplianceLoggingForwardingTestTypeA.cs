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
    public class ApplianceLoggingForwardingTestTypeA 
    {
        /// <summary>
        /// Flag specifying whether a default test message should be sent to the configured logging servers.
        /// If unset, no test message will be sent to the configured remote logging servers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "send_test_message")]
        public bool? SendTestMessage { get; set; }
    }
}
