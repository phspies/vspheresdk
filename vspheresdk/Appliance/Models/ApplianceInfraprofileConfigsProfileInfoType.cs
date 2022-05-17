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
    public class ApplianceInfraprofileConfigsProfileInfoType 
    {
        /// <summary>
        /// Name of the profile which is also a profile identifier.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// infraprofile.profile. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: infraprofile.profile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the profile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info", Required = Required.AllowNull)]
        public string Info { get; set; }
    }
}
