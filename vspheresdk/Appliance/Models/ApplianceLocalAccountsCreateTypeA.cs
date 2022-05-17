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
    public class ApplianceLocalAccountsCreateTypeA 
    {
        /// <summary>
        /// User configuration
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public ApplianceLocalAccountsConfigTypeA Config { get; set; }
    }
}
