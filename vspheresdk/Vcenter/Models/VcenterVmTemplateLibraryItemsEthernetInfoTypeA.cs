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
    public class VcenterVmTemplateLibraryItemsEthernetInfoTypeA 
    {
        /// <summary>
        /// Network backing type for the virtual Ethernet adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing_type", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsEthernetInfoNetworkBackingTypeEnumA BackingType { get; set; }
        /// <summary>
        /// MAC address type of the ethernet adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_type", Required = Required.AllowNull)]
        public VcenterVmTemplateLibraryItemsEthernetInfoMacAddressTypeEnumA MacType { get; set; }
        /// <summary>
        /// Identifier of the network backing the virtual Ethernet adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
    }
}
