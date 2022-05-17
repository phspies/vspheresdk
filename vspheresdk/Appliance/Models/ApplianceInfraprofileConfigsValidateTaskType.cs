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
    public class ApplianceInfraprofileConfigsValidateTaskType 
    {
        /// <summary>
        /// The JSON string representing the desired config specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_spec", Required = Required.AllowNull)]
        public string ConfigSpec { get; set; }
        /// <summary>
        /// The profile specification, if any
        /// only set if there is a profilespec avaliable for this import profilespec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile_spec")]
        public ApplianceInfraprofileConfigsExportType ProfileSpec { get; set; }
    }
}
