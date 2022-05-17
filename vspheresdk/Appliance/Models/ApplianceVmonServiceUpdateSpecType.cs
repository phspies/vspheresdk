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
    public class ApplianceVmonServiceUpdateSpecType 
    {
        /// <summary>
        /// Startup Type
        /// If unspecified, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "startup_type")]
        public ApplianceVmonServiceStartupTypeEnum StartupType { get; set; }
    }
}
