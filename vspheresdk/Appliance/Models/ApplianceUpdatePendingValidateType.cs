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
    public class ApplianceUpdatePendingValidateType 
    {
        /// <summary>
        /// map of user provided data with IDs
        /// The key in the parameter map must be an identifier for the resource type: applicance.update.pending.dataitem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_data", Required = Required.AllowNull)]
        public object UserData { get; set; }
    }
}
