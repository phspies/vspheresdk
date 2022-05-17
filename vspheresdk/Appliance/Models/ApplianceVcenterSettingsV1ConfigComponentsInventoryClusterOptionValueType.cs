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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterOptionValueType 
    {
        /// <summary>
        /// The name of the option using dot notation to reflect the option's position in a hierarchy. For example, you might have
        /// an option called "Ethernet" and another option that is a child of that called "Connection". In this case, the key for
        /// the latter could be defined as "Ethernet.Connection"
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// The value of the option. The Any data object type enables you to define any value for the option. Typically, however,
        /// the value of an option is of type String or Integer.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
    }
}
