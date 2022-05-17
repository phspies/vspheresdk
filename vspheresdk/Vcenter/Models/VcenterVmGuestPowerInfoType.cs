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
    public class VcenterVmGuestPowerInfoType 
    {
        /// <summary>
        /// The power state of the guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterVmGuestPowerStateEnumType State { get; set; }
        /// <summary>
        /// Flag indicating if the virtual machine is ready to process soft power operations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations_ready", Required = Required.AllowNull)]
        public bool OperationsReady { get; set; }
    }
}
