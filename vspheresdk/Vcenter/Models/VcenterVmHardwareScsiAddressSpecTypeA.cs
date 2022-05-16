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
    public class VcenterVmHardwareScsiAddressSpecTypeA 
    {
        /// <summary>
        /// Bus number of the adapter to which the device should be attached.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bus", Required = Required.AllowNull)]
        public long Bus { get; set; }
        /// <summary>
        /// Unit number of the device.
        /// If unset, the server will choose an available unit number on the specified adapter. If there are no available
        /// connections on the adapter, the request will be rejected.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public long? Unit { get; set; }
    }
}
