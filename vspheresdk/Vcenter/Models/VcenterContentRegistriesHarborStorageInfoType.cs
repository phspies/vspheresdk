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
    public class VcenterContentRegistriesHarborStorageInfoType 
    {
        /// <summary>
        /// Identifier of the storage policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public string Policy { get; set; }
        /// <summary>
        /// Total capacity for the registry storage (in mebibytes). This is the storage limit set on the Harbor registry. If a
        /// storage limit was not set on the registry, the default registry capacity - 204800 mebibytes is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity", Required = Required.AllowNull)]
        public long Capacity { get; set; }
        /// <summary>
        /// Overall storage used by the registry (in mebibytes). This is the sum of used storage associated with storage policies
        /// configured for the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used", Required = Required.AllowNull)]
        public long Used { get; set; }
    }
}
