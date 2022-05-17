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
    public class VcenterVmHardwareBootInfoType 
    {
        /// <summary>
        /// Firmware type used by the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareBootTypeEnum Type { get; set; }
        /// <summary>
        /// Flag indicating whether to use EFI legacy boot mode.
        /// This field is optional and it is only relevant when the value of Boot.Info.type is EFI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "efi_legacy_boot")]
        public bool? EfiLegacyBoot { get; set; }
        /// <summary>
        /// Protocol to use when attempting to boot the virtual machine over the network.
        /// This field is optional and it is only relevant when the value of Boot.Info.type is EFI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_protocol")]
        public VcenterVmHardwareBootNetworkProtocolEnumType NetworkProtocol { get; set; }
        /// <summary>
        /// Delay in milliseconds before beginning the firmware boot process when the virtual machine is powered on. This delay may
        /// be used to provide a time window for users to connect to the virtual machine console and enter BIOS setup mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "delay", Required = Required.AllowNull)]
        public long Delay { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual machine will automatically retry the boot process after a failure.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retry", Required = Required.AllowNull)]
        public bool Retry { get; set; }
        /// <summary>
        /// Delay in milliseconds before retrying the boot process after a failure; applicable only when Boot.Info.retry is true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retry_delay", Required = Required.AllowNull)]
        public long RetryDelay { get; set; }
        /// <summary>
        /// Flag indicating whether the firmware boot process will automatically enter setup mode the next time the virtual machine
        /// boots. Note that this flag will automatically be reset to false once the virtual machine enters setup mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enter_setup_mode", Required = Required.AllowNull)]
        public bool EnterSetupMode { get; set; }
    }
}
