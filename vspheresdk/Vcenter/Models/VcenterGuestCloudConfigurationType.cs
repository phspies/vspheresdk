using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterGuestCloudConfigurationType 
    {
        /// <summary>
        /// The type of the cloud configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterGuestCloudConfigurationTypeEnum Type { get; set; }
        /// <summary>
        /// cloud-init configuration
        /// This field is optional and it is only relevant when the value of CloudConfiguration.type is CLOUDINIT.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cloudinit")]
        public VcenterGuestCloudinitConfigurationType Cloudinit { get; set; }
    }
}
