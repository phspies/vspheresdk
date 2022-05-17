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
    public class VcenterVmStoragePolicyComplianceVmComplianceInfoTypeA 
    {
        /// <summary>
        /// Status of the compliance operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterVmStoragePolicyComplianceStatusEnumTypeA Status { get; set; }
        /// <summary>
        /// Date and time of the most recent compliance check.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_time", Required = Required.AllowNull)]
        public DateTime CheckTime { get; set; }
        /// <summary>
        /// Identifier of the storage policy associated with the virtual machine.
        /// If unset SPBM is unable to retrieve or determine the associated policy, Compliance.VmComplianceInfo.failure-cause is set
        /// in such casses.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.StoragePolicy. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vcenter.StoragePolicy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public string? Policy { get; set; }
        /// <summary>
        /// The exception that caused the compliance check to fail. There can be more than one cause, since a policy can contain
        /// capabilities from multiple providers. If empty, it implies no failures while retrieving compliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failure_cause", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageTypeA> FailureCause { get; set; }
    }
}
