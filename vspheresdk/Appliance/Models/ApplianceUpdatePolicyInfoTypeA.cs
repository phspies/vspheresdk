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
    public class ApplianceUpdatePolicyInfoTypeA 
    {
        /// <summary>
        /// Current appliance update custom repository URL.
        /// If unset update is checked at defaut URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "custom_URL")]
        public string? CustomURL { get; set; }
        /// <summary>
        /// Current appliance update default repository URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_URL", Required = Required.AllowNull)]
        public string DefaultURL { get; set; }
        /// <summary>
        /// Username for the update repository
        /// If unset username will not be used to login
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Schedule when the automatic check will be run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_schedule", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceUpdatePolicyTimeTypeA> CheckSchedule { get; set; }
        /// <summary>
        /// Automatically stage the latest update if available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_stage", Required = Required.AllowNull)]
        public bool AutoStage { get; set; }
        /// <summary>
        /// Is the appliance updated automatically. If set the appliance may ignore the check schedule or auto-stage settings.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_update", Required = Required.AllowNull)]
        public bool AutoUpdate { get; set; }
        /// <summary>
        /// Whether API client should allow the user to start update manually
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "manual_control", Required = Required.AllowNull)]
        public bool ManualControl { get; set; }
        /// <summary>
        /// Indicates whether certificates will be checked during patching.
        /// Warning: If this field is set to false, an insecure connection is made to the update repository which can potentially
        /// put the appliance security at risk.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_check", Required = Required.AllowNull)]
        public bool CertificateCheck { get; set; }
    }
}
