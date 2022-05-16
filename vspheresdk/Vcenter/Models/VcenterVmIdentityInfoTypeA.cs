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
    public class VcenterVmIdentityInfoTypeA 
    {
        /// <summary>
        /// Virtual machine name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// 128-bit SMBIOS UUID of a virtual machine represented as a hexadecimal string in "12345678-abcd-1234-cdef-123456789abc"
        /// format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios_uuid", Required = Required.AllowNull)]
        public string BiosUuid { get; set; }
        /// <summary>
        /// VirtualCenter-specific 128-bit UUID of a virtual machine, represented as a hexademical string. This identifier is used
        /// by VirtualCenter to uniquely identify all virtual machine instances, including those that may share the same SMBIOS
        /// UUID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "instance_uuid", Required = Required.AllowNull)]
        public string InstanceUuid { get; set; }
    }
}
