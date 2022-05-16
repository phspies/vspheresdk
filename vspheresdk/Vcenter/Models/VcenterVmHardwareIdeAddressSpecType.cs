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
    public class VcenterVmHardwareIdeAddressSpecType 
    {
        /// <summary>
        /// Flag specifying whether the device should be attached to the primary or secondary IDE adapter of the virtual machine.
        /// If unset, the server will choose a adapter with an available connection. If no IDE connections are available, the
        /// request will be rejected.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "primary")]
        public bool? Primary { get; set; }
        /// <summary>
        /// Flag specifying whether the device should be the master or slave device on the IDE adapter.
        /// If unset, the server will choose an available connection type. If no IDE connections are available, the request will be
        /// rejected.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master")]
        public bool? Master { get; set; }
    }
}
