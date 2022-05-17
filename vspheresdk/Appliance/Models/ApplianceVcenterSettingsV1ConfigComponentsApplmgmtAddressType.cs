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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAddressType 
    {
        /// <summary>
        /// The IPv6 address, for example, fc00:10:20:83:20c:29ff:fe94:bb5a.
        /// If set, the address was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
        /// <summary>
        /// The Origin of the IPv6 address. For more information, see RFC 4293.
        /// If set, the origin was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAddressOriginType Origin { get; set; }
        /// <summary>
        /// The IPv6 CIDR prefix, for example, 64.
        /// If set, the prefix was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public long? Prefix { get; set; }
        /// <summary>
        /// The Status of the IPv6 address. For more information, see RFC 4293.
        /// If set, the status was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAddressStatusType Status { get; set; }
    }
}
