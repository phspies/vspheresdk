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
    public class ApplianceVcenterSettingsV1ConfigInfoType 
    {
        /// <summary>
        /// The identifier of the profile. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.vcenter.settings.v1.config.profile. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: appliance.vcenter.settings.v1.config.profile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile", Required = Required.AllowNull)]
        public string Profile { get; set; }
        /// <summary>
        /// Version of the profile. Warning: This attribute is available as Technology Preview. These are early access APIs provided
        /// to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.vcenter.settings.v1.config.version. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: appliance.vcenter.settings.v1.config.version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Name of the profile. Warning: This attribute is available as Technology Preview. These are early access APIs provided to
        /// test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Creation time of the profile. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_time", Required = Required.AllowNull)]
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// Owner of the profile, the one who created. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner", Required = Required.AllowNull)]
        public string Owner { get; set; }
        /// <summary>
        /// Custom description provided by the user. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// If unset description will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The desired state. Warning: This attribute is available as Technology Preview. These are early access APIs provided to
        /// test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_state", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1DesiredStateType DesiredState { get; set; }
    }
}
