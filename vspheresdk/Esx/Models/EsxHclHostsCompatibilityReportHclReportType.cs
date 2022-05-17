using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxHclHostsCompatibilityReportHclReportType 
    {
        /// <summary>
        /// FQDN identifying the ESXi host that the report refers to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Indicates for which ESXi release the report is generated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target_release", Required = Required.AllowNull)]
        public string TargetRelease { get; set; }
        /// <summary>
        /// Lists compatibility information for the ESXi's server part.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server_hcl", Required = Required.AllowNull)]
        public EsxHclHostsCompatibilityReportServerHclInfoType ServerHcl { get; set; }
        /// <summary>
        /// Lists compatibility information for discoverable PCI devices of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices_hcl")]
        public Dictionary<string,EsxHclHostsCompatibilityReportDeviceHclInfoType> DevicesHcl { get; set; }
        /// <summary>
        /// Specifies the time the report was generated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "generated_at", Required = Required.AllowNull)]
        public DateTime GeneratedAt { get; set; }
        /// <summary>
        /// Notifications returned by the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxHclNotificationsType Notifications { get; set; }
    }
}
