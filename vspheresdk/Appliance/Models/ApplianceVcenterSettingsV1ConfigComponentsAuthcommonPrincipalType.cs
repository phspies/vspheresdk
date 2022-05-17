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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthcommonPrincipalType 
    {
        /// <summary>
        /// Principal name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Is a Group
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group", Required = Required.AllowNull)]
        public bool Group { get; set; }
    }
}
