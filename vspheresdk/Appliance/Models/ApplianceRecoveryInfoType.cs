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
    public class ApplianceRecoveryInfoType 
    {
        /// <summary>
        /// Is recovery supported in this appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported", Required = Required.AllowNull)]
        public bool Supported { get; set; }
    }
}
