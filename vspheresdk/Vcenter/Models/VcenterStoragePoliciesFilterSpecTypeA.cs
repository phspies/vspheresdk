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
    public class VcenterStoragePoliciesFilterSpecTypeA 
    {
        /// <summary>
        /// Identifiers of storage policies that can match the filter.
        /// If unset or empty, storage policies with any identifiers match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.StoragePolicy. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: vcenter.StoragePolicy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policies")]
        public IList<string> Policies { get; set; }
    }
}
