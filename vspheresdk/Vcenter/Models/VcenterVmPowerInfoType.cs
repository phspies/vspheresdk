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
    public class VcenterVmPowerInfoType 
    {
        /// <summary>
        /// Power state of the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterVmPowerStateType State { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual machine was powered off cleanly. This field may be used to detect that the virtual
        /// machine crashed unexpectedly and should be restarted.
        /// This field is optional and it is only relevant when the value of Power.Info.state is POWERED_OFF.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clean_power_off")]
        public bool? CleanPowerOff { get; set; }
    }
}
