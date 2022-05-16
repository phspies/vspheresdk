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
    public class VcenterGuestWindowsSysprepType 
    {
        /// <summary>
        /// A list of commands to run at first user logon, after customizing the guest. These commands are directly mapped to the
        /// GuiRunOnce key in the sysprep.xml answer file. These commands are transferred into the sysprep.xml file that
        /// VirtualCenter stores on the target virtual disk. For more information about performing unattended installation, check
        /// https://technet.microsoft.com/en-us/library/cc771830(v=ws.10).aspx The commands listed here ar executed when a user logs
        /// on the first time after customization completes. The logon may be driven by GuiUnattended.auto-logon setting. These
        /// commands are directly mapped to the GuiRunOnce key in the
        /// If unset, no commands are run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gui_run_once_commands")]
        public IList<string> GuiRunOnceCommands { get; set; }
        /// <summary>
        /// Personal data pertaining to the owner of the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_data", Required = Required.AllowNull)]
        public VcenterGuestUserDataType UserData { get; set; }
        /// <summary>
        /// Information needed to join a workgroup or domain.
        /// If unset, the guest will not be joined to any workgroup or a domain.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public VcenterGuestDomainType Domain { get; set; }
        /// <summary>
        /// Information related to unattended installation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gui_unattended", Required = Required.AllowNull)]
        public VcenterGuestGuiUnattendedType GuiUnattended { get; set; }
    }
}
