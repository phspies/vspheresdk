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
    public class ApplianceVmonServiceUpdateType 
    {
        /// <summary>
        /// Service Update specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public ApplianceVmonServiceUpdateSpecType Spec { get; set; }
    }
}
