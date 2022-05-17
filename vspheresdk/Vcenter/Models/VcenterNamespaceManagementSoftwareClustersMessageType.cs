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
    public class VcenterNamespaceManagementSoftwareClustersMessageType 
    {
        /// <summary>
        /// Type of the message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSoftwareClustersMessageSeverityEnumType Severity { get; set; }
        /// <summary>
        /// Details about the message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Details { get; set; }
    }
}
