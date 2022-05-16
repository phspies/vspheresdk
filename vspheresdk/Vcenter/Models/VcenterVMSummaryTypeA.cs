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
    public class VcenterVMSummaryTypeA 
    {
        /// <summary>
        /// Identifier of the virtual machine.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm", Required = Required.AllowNull)]
        public string Vm { get; set; }
        /// <summary>
        /// Name of the Virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Power state of the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "power_state", Required = Required.AllowNull)]
        public VcenterVmPowerStateTypeA PowerState { get; set; }
        /// <summary>
        /// Number of CPU cores.
        /// This field will be unset if the virtual machine configuration is not available. For example, the configuration
        /// information would be unavailable if the server is unable to access the virtual machine files on disk, and is often also
        /// unavailable during the intial phases of virtual machine creation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_count")]
        public long? CpuCount { get; set; }
        /// <summary>
        /// Memory size in mebibytes.
        /// This field will be unset if the virtual machine configuration is not available. For example, the configuration
        /// information would be unavailable if the server is unable to access the virtual machine files on disk, and is often also
        /// unavailable during the intial phases of virtual machine creation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_size_MiB")]
        public long? MemorySizeMiB { get; set; }
    }
}
