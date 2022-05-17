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
    public class ApplianceLocalAccountsCreateType 
    {
        /// <summary>
        /// User login name
        /// The parameter must be an identifier for the resource type: appliance.local_accounts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// User configuration
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public ApplianceLocalAccountsConfigType Config { get; set; }
    }
}
