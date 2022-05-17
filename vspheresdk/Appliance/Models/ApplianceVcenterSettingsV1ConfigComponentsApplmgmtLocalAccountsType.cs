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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtLocalAccountsType 
    {
        /// <summary>
        /// Full name of the user
        /// If unset, the value was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullname")]
        public string? Fullname { get; set; }
        /// <summary>
        /// User roles
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }
        /// <summary>
        /// Flag indicating if the account is enabled
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Is the user password set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "has_password")]
        public bool? HasPassword { get; set; }
        /// <summary>
        /// Minimum number of days between password change
        /// If unset, pasword can be changed any time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_days_between_password_change")]
        public long? MinDaysBetweenPasswordChange { get; set; }
        /// <summary>
        /// Maximum number of days between password change
        /// If unset, password never expires.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_days_between_password_change")]
        public long? MaxDaysBetweenPasswordChange { get; set; }
        /// <summary>
        /// Number of days of warning before password expires
        /// If unset, a user is never warned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warn_days_before_password_expiration")]
        public long? WarnDaysBeforePasswordExpiration { get; set; }
        /// <summary>
        /// Password
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Email address of the local account
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
    }
}
