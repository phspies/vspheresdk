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
    public class VcenterResourcePoolCreateTypeA 
    {
        /// <summary>
        /// Specification of the new resource pool to be created, see ResourcePool.CreateSpec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterResourcePoolCreateSpecTypeA Spec { get; set; }
    }
}
