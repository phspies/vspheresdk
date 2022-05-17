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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtSoftwareUpdatePolicyType 
    {
        /// <summary>
        /// Current appliance update repository URL. Enter "default" to reset the url to the default url.
        /// Only set if custom URL required
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Default appliance update repository URL.
        /// Only set if default URL required
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_URL")]
        public string? DefaultURL { get; set; }
        /// <summary>
        /// Check for update at the pre-configured repository URL.
        /// Only set if auto stage is enable.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_stage")]
        public bool? AutoStage { get; set; }
        /// <summary>
        /// The Time structure defines day and time the automatic check for new updates will be run.
        /// Only set if Time required.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_schedule")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtTimeType> CheckSchedule { get; set; }
        /// <summary>
        /// Username for the url update repository
        /// Only set if SoftwareUpdatePolicy requires username.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password for the url update repository
        /// Only set if SoftwareUpdatePolicy requires password.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Indicates whether certificates will be checked during patching.
        /// Warning: If this field is set to false, an insecure connection is made to the update repository which can potentially
        /// put the appliance security at risk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable_SSL_cert_validation")]
        public bool? EnableSslcertValidation { get; set; }
    }
}
