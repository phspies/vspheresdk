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
    public class ApplianceUpdatePolicySetTypeA 
    {
        /// <summary>
        /// Info structure containing the policy for the appliance update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public ApplianceUpdatePolicyConfigTypeA Policy { get; set; }
    }
}
