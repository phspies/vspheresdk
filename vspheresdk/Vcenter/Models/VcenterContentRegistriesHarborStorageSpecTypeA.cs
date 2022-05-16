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
    public class VcenterContentRegistriesHarborStorageSpecTypeA 
    {
        /// <summary>
        /// Identifier of the storage policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public string Policy { get; set; }
        /// <summary>
        /// The maximum amount of storage (in mebibytes) which can be utilized by the registry for this specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; set; }
    }
}
