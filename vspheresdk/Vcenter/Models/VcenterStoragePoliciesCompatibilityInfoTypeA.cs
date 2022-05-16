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
    public class VcenterStoragePoliciesCompatibilityInfoTypeA 
    {
        /// <summary>
        /// Info about a list of datastores compatible with a specific storage policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible_datastores", Required = Required.AllowNull)]
        public Dictionary<string,VcenterStoragePoliciesCompatibleDatastoreInfoTypeA> CompatibleDatastores { get; set; }
    }
}
