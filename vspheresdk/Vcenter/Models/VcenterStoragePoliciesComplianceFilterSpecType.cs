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
    public class VcenterStoragePoliciesComplianceFilterSpecType 
    {
        /// <summary>
        /// Compliance Status that a virtual machine must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public Dictionary<string,VcenterStoragePoliciesComplianceStatusEnumType> Status { get; set; }
    }
}
