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
    public class ApplianceInfraprofileConfigsProfilesSpecType 
    {
        /// <summary>
        /// Encryption Key to encrypt/decrypt profiles.
        /// If unset encryption will not be used for the profile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "encryption_key")]
        public string? EncryptionKey { get; set; }
        /// <summary>
        /// Custom description provided by the user.
        /// If unset description will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Profiles to be exported/imported.
        /// If unset or empty, all profiles will be returned.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// infraprofile.profile. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: infraprofile.profile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "profiles")]
        public IList<string> Profiles { get; set; }
    }
}
