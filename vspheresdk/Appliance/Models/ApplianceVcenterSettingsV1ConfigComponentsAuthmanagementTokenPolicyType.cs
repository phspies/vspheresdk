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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementTokenPolicyType 
    {
        /// <summary>
        /// Clock tolerance ms.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clock_tolerance", Required = Required.AllowNull)]
        public long ClockTolerance { get; set; }
        /// <summary>
        /// Maximum token renewal count.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_renewal", Required = Required.AllowNull)]
        public long TokenRenewal { get; set; }
        /// <summary>
        /// Maximum token delegation count.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "token_delegation", Required = Required.AllowNull)]
        public long TokenDelegation { get; set; }
        /// <summary>
        /// Maximum Bearer RefreshToken lifetime.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bearer_refresh", Required = Required.AllowNull)]
        public long BearerRefresh { get; set; }
        /// <summary>
        /// Maximum HoK RefreshToken lifetime.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hok_refresh", Required = Required.AllowNull)]
        public long HokRefresh { get; set; }
    }
}
