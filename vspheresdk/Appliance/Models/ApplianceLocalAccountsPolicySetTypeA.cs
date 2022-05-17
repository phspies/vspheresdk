using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceLocalAccountsPolicySetTypeA 
    {
        /// <summary>
        /// Global password policy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public ApplianceLocalAccountsPolicyInfoTypeA Policy { get; set; }
    }
}
