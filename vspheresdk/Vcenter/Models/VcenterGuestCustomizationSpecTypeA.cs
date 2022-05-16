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
    public class VcenterGuestCustomizationSpecTypeA 
    {
        /// <summary>
        /// Settings to be applied to the guest during the customization.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "configuration_spec", Required = Required.AllowNull)]
        public VcenterGuestConfigurationSpecTypeA ConfigurationSpec { get; set; }
        /// <summary>
        /// Global DNS settings constitute the DNS settings that are not specific to a particular virtual network adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "global_DNS_settings", Required = Required.AllowNull)]
        public VcenterGuestGlobalDNSSettingsTypeA GlobalDnssettings { get; set; }
        /// <summary>
        /// IP settings that are specific to a particular virtual network adapter. The AdapterMapping structure maps a network
        /// adapter's MAC address to its IPSettings. May be empty if there are no network adapters, else should match number of
        /// network adapters configured for the VM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interfaces", Required = Required.AllowNull)]
        public Dictionary<string,VcenterGuestAdapterMappingTypeA> Interfaces { get; set; }
    }
}
