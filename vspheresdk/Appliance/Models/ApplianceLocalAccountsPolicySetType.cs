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
    public class ApplianceLocalAccountsPolicySetType 
    {
        /// <summary>
        /// Maximum number of days a password may be used. If the password is older than this, a password change will be forced.
        /// If unset then the restriction will be ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_days")]
        public long? MaxDays { get; set; }
        /// <summary>
        /// Minimum number of days allowed between password changes. Any password changes attempted sooner than this will be
        /// rejected.
        /// If unset then the restriction will be ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_days")]
        public long? MinDays { get; set; }
        /// <summary>
        /// Number of days warning given before a password expires. A zero means warning is given only upon the day of expiration.
        /// If unset then no warning will be provided.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warn_days")]
        public long? WarnDays { get; set; }
    }
}
