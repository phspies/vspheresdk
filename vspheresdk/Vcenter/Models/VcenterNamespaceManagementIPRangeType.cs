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
    public class VcenterNamespaceManagementIprangeType 
    {
        /// <summary>
        /// The starting address of the range.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// The number of IP addresses in the range.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "count", Required = Required.AllowNull)]
        public long Count { get; set; }
    }
}
