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
    public class ApplianceNetworkingDnsDomainsSetType 
    {
        /// <summary>
        /// List of domains.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domains", Required = Required.AllowNull)]
        public IList<string> Domains { get; set; }
    }
}
