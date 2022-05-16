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
    public class VcenterStoragePoliciesComplianceVmfilterSpecType 
    {
        /// <summary>
        /// Compliance Status that a virtual machine must have to match the filter. Atleast one status must be specified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public Dictionary<string,VcenterStoragePoliciesComplianceVmstatusType> Status { get; set; }
        /// <summary>
        /// Identifiers of virtual machines that can match the filter
        /// If unset or empty, virtual machines with any identifier matches the filter
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vms")]
        public IList<string> Vms { get; set; }
    }
}
