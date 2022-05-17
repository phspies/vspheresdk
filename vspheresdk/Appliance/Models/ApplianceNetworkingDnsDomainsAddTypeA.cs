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
    public class ApplianceNetworkingDnsDomainsAddTypeA 
    {
        /// <summary>
        /// Domain to add.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain", Required = Required.AllowNull)]
        public string Domain { get; set; }
    }
}
