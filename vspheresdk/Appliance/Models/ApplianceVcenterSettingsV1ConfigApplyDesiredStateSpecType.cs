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
    public class ApplianceVcenterSettingsV1ConfigApplyDesiredStateSpecType 
    {
        /// <summary>
        /// Defines the desired state. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_state", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1DesiredStateType DesiredState { get; set; }
        /// <summary>
        /// applySpec to include a message with the apply. Warning: This attribute is available as Technology Preview. These are
        /// early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "apply_spec", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigApplySpecType ApplySpec { get; set; }
    }
}
