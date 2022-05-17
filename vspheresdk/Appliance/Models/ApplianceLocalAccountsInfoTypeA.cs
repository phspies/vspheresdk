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
    public class ApplianceLocalAccountsInfoTypeA 
    {
        /// <summary>
        /// Full name of the user
        /// If unset, the value was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fullname")]
        public string? Fullname { get; set; }
        /// <summary>
        /// Email address of the local account
        /// If unset, the value was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
        /// <summary>
        /// User roles
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// appliance.roles. When operations return a value of this structure as a result, the field will contain identifiers for
        /// the resource type: appliance.roles.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles", Required = Required.AllowNull)]
        public IList<string> Roles { get; set; }
        /// <summary>
        /// Flag indicating if the account is enabled
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Is the user password set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "has_password", Required = Required.AllowNull)]
        public bool HasPassword { get; set; }
        /// <summary>
        /// Date and time password was changed.
        /// If unset, the password was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_password_change")]
        public DateTime? LastPasswordChange { get; set; }
        /// <summary>
        /// Date when the account's password will expire
        /// If unset, the password never expires.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password_expires_at")]
        public DateTime? PasswordExpiresAt { get; set; }
        /// <summary>
        /// Date and time account will be locked after password expiration.
        /// If unset, account will not be locked.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "inactive_at")]
        public DateTime? InactiveAt { get; set; }
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
    }
}
