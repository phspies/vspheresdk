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
    public class VcenterGuestWindowsConfigurationTypeA 
    {
        /// <summary>
        /// A value specifying the action that should be taken after customization.
        /// If unset, the REBOOT option will be chosen.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reboot")]
        public VcenterGuestWindowsConfigurationRebootOptionTypeA Reboot { get; set; }
        /// <summary>
        /// Customization settings like user details, administrator details, etc for the windows guest operating system. Exactly one
        /// of WindowsConfiguration.sysprep or WindowsConfiguration.sysprep-xml must be specified.
        /// If unset, sysprep settings will not be applied to the windows guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sysprep")]
        public VcenterGuestWindowsSysprepTypeA Sysprep { get; set; }
        /// <summary>
        /// All settings specified in a XML format. This is the content of a typical answer.xml file that is used by System
        /// administrators during the Windows image customization. Check
        /// https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/update-windows-settings-and-scripts-create-your-own-answer-file-sxs
        /// Exactly one of WindowsConfiguration.sysprep or WindowsConfiguration.sysprep-xml must be specified.
        /// If unset, sysprep settings will not be applied to the windows guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sysprep_xml")]
        public string? SysprepXml { get; set; }
    }
}
