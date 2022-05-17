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
    public class ApplianceHealthDatabaseInfoType 
    {
        /// <summary>
        /// Database health status
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceHealthDatabaseInfoStatusType Status { get; set; }
        /// <summary>
        /// Messages describing any issues with the database, along with their severity.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceHealthDatabaseMessageType> Messages { get; set; }
    }
}
