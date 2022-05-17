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
    public class ApplianceRecoveryBackupJobDetailsBuildInfoType 
    {
        /// <summary>
        /// Appliance product type, for example 6.8.2 GA
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version_name", Required = Required.AllowNull)]
        public string VersionName { get; set; }
        /// <summary>
        /// Appliance version, for example 6.8.2.10000
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Build Number of the appliance
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "build_number", Required = Required.AllowNull)]
        public string BuildNumber { get; set; }
    }
}
