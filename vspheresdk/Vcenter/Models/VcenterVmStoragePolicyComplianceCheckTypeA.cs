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
    public class VcenterVmStoragePolicyComplianceCheckTypeA 
    {
        /// <summary>
        /// Parameter specifies the entities on which storage policy compliance check is to be invoked. The storage compliance Info
        /// Compliance.Info is returned.
        /// If unset, the behavior is equivalent to a Compliance.CheckSpec with CheckSpec#vmHome set to true and CheckSpec#disks
        /// populated with all disks attached to the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_spec")]
        public VcenterVmStoragePolicyComplianceCheckSpecTypeA CheckSpec { get; set; }
    }
}
