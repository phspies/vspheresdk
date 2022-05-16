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
    public class VcenterVmHardwareSerialSummaryType 
    {
        /// <summary>
        /// Identifier of the virtual serial port.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.SerialPort. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.vm.hardware.SerialPort.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public string Port { get; set; }
    }
}
