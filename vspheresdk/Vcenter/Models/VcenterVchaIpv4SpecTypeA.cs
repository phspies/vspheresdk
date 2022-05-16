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
    public class VcenterVchaIpv4SpecTypeA 
    {
        /// <summary>
        /// IPV4 address to be used to configure the interface.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// The subnet mask for the interface.
        /// If unset and the Ipv4Spec.prefix field is unset, then an error will be reported.
        /// If unset and the Ipv4Spec.prefix field is set, then the Ipv4Spec.prefix field will be used to create a subnet mask whose
        /// first prefix bits are 1 and the remaining bits 0.
        /// If both the Ipv4Spec.subnet-mask field and the Ipv4Spec.prefix field are set and they do not represent the same value,
        /// then an error will be reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask")]
        public string? SubnetMask { get; set; }
        /// <summary>
        /// The CIDR prefix for the interface.
        /// If unset and the Ipv4Spec.subnet-mask field is unset, this an error will be reported.
        /// If unset and the Ipv4Spec.subnet-mask field is set, then the Ipv4Spec.subnet-mask field will be used.
        /// If both the Ipv4Spec.subnet-mask field and the Ipv4Spec.prefix field are set and they do not represent the same value,
        /// then an error will be reported.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public long? Prefix { get; set; }
    }
}
