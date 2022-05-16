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
    public class VcenterGuestGuiUnattendedTypeA 
    {
        /// <summary>
        /// Flag to determine whether or not the machine automatically logs on as Administrator. See the GuiUnattended.password
        /// property. If GuiUnattended.auto-logon flag is set, then GuiUnattended.password must not be unset or the guest
        /// customization will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_logon", Required = Required.AllowNull)]
        public bool AutoLogon { get; set; }
        /// <summary>
        /// If the GuiUnattended.auto-logon flag is set, then this property specifies the number of times the machine should
        /// automatically log on as Administrator. Generally it should be 1, but if the setup requires a number of reboots, you may
        /// want to increase it. This number may be determined by the list of commands.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_logon_count", Required = Required.AllowNull)]
        public long AutoLogonCount { get; set; }
        /// <summary>
        /// The new administrator password for the machine. To specify that the password should be set to blank (that is, no
        /// password), leave it unset.
        /// If unset, blank password will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// The time zone index for the virtual machine. Numbers correspond to time zones at
        /// https://support.microsoft.com/en-us/help/973627/microsoft-time-zone-index-values
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time_zone", Required = Required.AllowNull)]
        public long TimeZone { get; set; }
    }
}
