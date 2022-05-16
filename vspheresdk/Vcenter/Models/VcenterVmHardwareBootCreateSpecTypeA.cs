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
    public class VcenterVmHardwareBootCreateSpecTypeA 
    {
        /// <summary>
        /// Firmware type to be used by the virtual machine.
        /// If unset, defaults to value that is recommended for the guest OS and is supported for the virtual hardware version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterVmHardwareBootTypeA Type { get; set; }
        /// <summary>
        /// Flag indicating whether to use EFI legacy boot mode.
        /// If unset, defaults to value that is recommended for the guest OS and is supported for the virtual hardware version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "efi_legacy_boot")]
        public bool? EfiLegacyBoot { get; set; }
        /// <summary>
        /// Protocol to use when attempting to boot the virtual machine over the network.
        /// If unset, defaults to a system defined default value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_protocol")]
        public VcenterVmHardwareBootNetworkProtocolTypeA NetworkProtocol { get; set; }
        /// <summary>
        /// Delay in milliseconds before beginning the firmware boot process when the virtual machine is powered on. This delay may
        /// be used to provide a time window for users to connect to the virtual machine console and enter BIOS setup mode.
        /// If unset, default value is 0.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "delay")]
        public long? Delay { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual machine should automatically retry the boot process after a failure.
        /// If unset, default value is false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retry")]
        public bool? Retry { get; set; }
        /// <summary>
        /// Delay in milliseconds before retrying the boot process after a failure; applicable only when Boot.Info.retry is true.
        /// If unset, default value is 10000.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retry_delay")]
        public long? RetryDelay { get; set; }
        /// <summary>
        /// Flag indicating whether the firmware boot process should automatically enter setup mode the next time the virtual
        /// machine boots. Note that this flag will automatically be reset to false once the virtual machine enters setup mode.
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enter_setup_mode")]
        public bool? EnterSetupMode { get; set; }
    }
}
