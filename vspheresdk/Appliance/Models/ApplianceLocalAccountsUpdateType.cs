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
    public class ApplianceLocalAccountsUpdateType 
    {
        /// <summary>
        /// Password
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Old password of the user (required in case of the password change, not required if superAdmin user changes the password
        /// of the other user)
        /// If unset, user may not have password set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "old_password")]
        public string? OldPassword { get; set; }
        /// <summary>
        /// Full name of the user
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "full_name")]
        public string? FullName { get; set; }
        /// <summary>
        /// Email address of the local account
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
        /// <summary>
        /// User roles
        /// If unset, value will not be changed
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// appliance.roles. When operations return a value of this structure as a result, the field will contain identifiers for
        /// the resource type: appliance.roles.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }
        /// <summary>
        /// Flag indicating if the account is enabled
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Flag indicating if the account password expires
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password_expires")]
        public bool? PasswordExpires { get; set; }
        /// <summary>
        /// Date when the account's password will expire
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password_expires_at")]
        public DateTime? PasswordExpiresAt { get; set; }
        /// <summary>
        /// Flag indicating if the account will be locked after password expiration
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "inactive_after_password_expiration")]
        public bool? InactiveAfterPasswordExpiration { get; set; }
        /// <summary>
        /// Number of days after password expiration before the account will be locked
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "days_after_password_expiration")]
        public long? DaysAfterPasswordExpiration { get; set; }
        /// <summary>
        /// Minimum number of days between password change
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_days_between_password_change")]
        public long? MinDaysBetweenPasswordChange { get; set; }
        /// <summary>
        /// Maximum number of days between password change
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_days_between_password_change")]
        public long? MaxDaysBetweenPasswordChange { get; set; }
        /// <summary>
        /// Number of days of warning before password expires
        /// If unset, value will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warn_days_before_password_expiration")]
        public long? WarnDaysBeforePasswordExpiration { get; set; }
    }
}
