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
    public class ApplianceSystemTimeTimezoneSetTypeA 
    {
        /// <summary>
        /// Time zone name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
