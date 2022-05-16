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
    public class VcenterGuestConfigurationSpecType 
    {
        /// <summary>
        /// Guest customization specification for a Windows guest operating system
        /// If unset, ConfigurationSpec.linux-config or ConfigurationSpec.cloud-config must be set. Otherwise, an appropriate fault
        /// will be thrown.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "windows_config")]
        public VcenterGuestWindowsConfigurationType WindowsConfig { get; set; }
        /// <summary>
        /// Guest customization specification for a linux guest operating system
        /// If unset, ConfigurationSpec.windows-config or ConfigurationSpec.cloud-config must be set. Otherwise, an appropriate
        /// fault will be thrown.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "linux_config")]
        public VcenterGuestLinuxConfigurationType LinuxConfig { get; set; }
        /// <summary>
        /// Guest customization specification with cloud configuration.
        /// If unset, ConfigurationSpec.windows-config or ConfigurationSpec.linux-config must be set. Otherwise, an appropriate
        /// fault will be thrown.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config")]
        public VcenterGuestCloudConfigurationType CloudConfig { get; set; }
    }
}
