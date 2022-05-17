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
    public class ApplianceVcenterSettingsV1ConfigScanSpecType 
    {
        /// <summary>
        /// Message for the scan. This may act as an identification for the scan operation. Warning: This attribute is available as
        /// Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since
        /// this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them
        /// in production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// If unset, the message will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// Defines the desired state. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_state", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1DesiredStateType DesiredState { get; set; }
    }
}