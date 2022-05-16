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
    public class VcenterNamespaceManagementVirtualMachineClassesMessageType 
    {
        /// <summary>
        /// Type of the message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        public VcenterNamespaceManagementVirtualMachineClassesMessageMessageSeverityType Severity { get; set; }
        /// <summary>
        /// Details about the message.
        /// If unset, message details are not required for taking actions.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public VapiStdLocalizableMessageType Details { get; set; }
    }
}
