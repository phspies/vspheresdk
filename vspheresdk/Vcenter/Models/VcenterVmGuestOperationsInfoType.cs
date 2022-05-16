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
    public class VcenterVmGuestOperationsInfoType 
    {
        /// <summary>
        /// Guest operations availability. Whether or not the virtual machine is ready to process guest operations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "guest_operations_ready", Required = Required.AllowNull)]
        public bool GuestOperationsReady { get; set; }
        /// <summary>
        /// Interactive guest operations availability. Whether or not the virtual machine is ready to process interactive guest
        /// operations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interactive_guest_operations_ready", Required = Required.AllowNull)]
        public bool InteractiveGuestOperationsReady { get; set; }
    }
}
