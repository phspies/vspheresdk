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
    public class VcenterVmGuestNetworkingInfoTypeA 
    {
        /// <summary>
        /// Client DNS values. Data assigned by DNS.
        /// If unset no DNS assigned value exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_values")]
        public VcenterVmGuestDnsAssignedValuesTypeA DnsValues { get; set; }
        /// <summary>
        /// Client DNS configuration. How DNS queries are resolved.
        /// If unset no DNS assigned value exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns")]
        public VcenterVmGuestDnsConfigInfoTypeA Dns { get; set; }
    }
}
