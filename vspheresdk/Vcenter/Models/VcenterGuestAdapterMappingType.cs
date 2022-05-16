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
    public class VcenterGuestAdapterMappingType 
    {
        /// <summary>
        /// The MAC address of a network adapter being customized.
        /// If unset, the customization process maps the the settings from the list of AdapterMappings.IPSettings in the
        /// CustomizationSpec.interfaces to the virtual machine's network adapters, in PCI slot order. The first virtual network
        /// adapter on the PCI bus is assigned interfaces[0].IPSettings, the second adapter is assigned interfaces[1].IPSettings,
        /// and so on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// The IP settings for the associated virtual network adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "adapter", Required = Required.AllowNull)]
        public VcenterGuestIpsettingsType Adapter { get; set; }
    }
}
