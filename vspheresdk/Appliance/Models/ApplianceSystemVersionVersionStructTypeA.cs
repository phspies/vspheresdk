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
    public class ApplianceSystemVersionVersionStructTypeA 
    {
        /// <summary>
        /// Appliance version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Appliance name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "product", Required = Required.AllowNull)]
        public string Product { get; set; }
        /// <summary>
        /// Appliance build number.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "build", Required = Required.AllowNull)]
        public string Build { get; set; }
        /// <summary>
        /// Type of product. Same product can have different deployment options, which is represented by type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// Summary of patch (empty string, if the appliance has not been patched)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary", Required = Required.AllowNull)]
        public string Summary { get; set; }
        /// <summary>
        /// Release date of patch (empty string, if the appliance has not been patched)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "releasedate", Required = Required.AllowNull)]
        public string Releasedate { get; set; }
        /// <summary>
        /// Display the date and time when this system was first installed. Value will not change on subsequent updates.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "install_time", Required = Required.AllowNull)]
        public string InstallTime { get; set; }
    }
}
