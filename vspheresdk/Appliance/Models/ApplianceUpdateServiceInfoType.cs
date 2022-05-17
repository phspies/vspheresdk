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
    public class ApplianceUpdateServiceInfoType 
    {
        /// <summary>
        /// Service ID
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.service. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: appliance.service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service", Required = Required.AllowNull)]
        public string Service { get; set; }
        /// <summary>
        /// Service description
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
    }
}
