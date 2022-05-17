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
    public class ApplianceUpdatePolicySetType 
    {
        /// <summary>
        /// Current appliance update repository URL.
        /// If unset then default URL is assumed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "custom_URL")]
        public string? CustomURL { get; set; }
        /// <summary>
        /// Username for the update repository
        /// If unset username will not be used to login
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password for the update repository
        /// password If unset password will not be used to login
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Schedule when the automatic check will be run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_schedule", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceUpdatePolicyTimeType> CheckSchedule { get; set; }
        /// <summary>
        /// Automatically stage the latest update if available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_stage", Required = Required.AllowNull)]
        public bool AutoStage { get; set; }
        /// <summary>
        /// Indicates whether certificates will be checked during patching.
        /// Warning: Setting this field to false will result in an insecure connection to update repository which can potentially
        /// put the appliance security at risk.
        /// 
        /// certificateCheck If unset the certificate checks are enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_check")]
        public bool? CertificateCheck { get; set; }
    }
}
