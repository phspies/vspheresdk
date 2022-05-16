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
    public class VcenterVmStoragePolicyDiskPolicySpecType 
    {
        /// <summary>
        /// Policy type to be used while performing update operation on the virtual disks.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmStoragePolicyDiskPolicySpecPolicyType Type { get; set; }
        /// <summary>
        /// Storage Policy identification.
        /// This field is optional and it is only relevant when the value of Policy.DiskPolicySpec.type is USE_SPECIFIED_POLICY.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.StoragePolicy. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vcenter.StoragePolicy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy")]
        public string? Policy { get; set; }
    }
}
