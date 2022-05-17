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
    public class ApplianceRecoveryBackupLocationSpecType 
    {
        /// <summary>
        /// Backup location URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Username for the given location.
        /// If unset authentication will not be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_user")]
        public string? LocationUser { get; set; }
        /// <summary>
        /// Password for the given location.
        /// If unset authentication will not be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_password")]
        public string? LocationPassword { get; set; }
    }
}
