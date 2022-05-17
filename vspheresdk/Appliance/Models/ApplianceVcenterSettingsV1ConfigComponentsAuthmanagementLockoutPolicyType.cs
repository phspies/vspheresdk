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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementLockoutPolicyType 
    {
        /// <summary>
        /// Maximum number of failed login attempts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failed_login_attempts", Required = Required.AllowNull)]
        public long FailedLoginAttempts { get; set; }
        /// <summary>
        /// Time interval between failures.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failure_interval", Required = Required.AllowNull)]
        public long FailureInterval { get; set; }
        /// <summary>
        /// Unlock time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "unlock_time", Required = Required.AllowNull)]
        public long UnlockTime { get; set; }
    }
}
