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
    public class VcenterNamespacesInstancesStorageSpecTypeA 
    {
        /// <summary>
        /// ID of the storage policy. A Kubernetes storage class is created for this storage policy if it does not exist already.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public string Policy { get; set; }
        /// <summary>
        /// The maximum amount of storage (in mebibytes) which can be utilized by the namespace for this specification.
        /// If unset, no limits are placed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; set; }
    }
}
