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
    public class VcenterVmGuestIdentityInfoType 
    {
        /// <summary>
        /// Guest operating system identifier (short name).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public VcenterVmGuestOsenumType Name { get; set; }
        /// <summary>
        /// Guest operating system family.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "family", Required = Required.AllowNull)]
        public VcenterVmGuestOsfamilyEnumType Family { get; set; }
        /// <summary>
        /// Guest operating system full name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "full_name", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType FullName { get; set; }
        /// <summary>
        /// Hostname of the guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_name", Required = Required.AllowNull)]
        public string HostName { get; set; }
        /// <summary>
        /// IP address assigned by the guest operating system.
        /// If unset the guest does not have an IP address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}
