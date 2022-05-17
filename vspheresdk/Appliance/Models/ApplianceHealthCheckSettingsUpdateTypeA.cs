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
    public class ApplianceHealthCheckSettingsUpdateTypeA 
    {
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health_settings", Required = Required.AllowNull)]
        public ApplianceHealthCheckSettingsUpdateSpecTypeA HealthSettings { get; set; }
    }
}
