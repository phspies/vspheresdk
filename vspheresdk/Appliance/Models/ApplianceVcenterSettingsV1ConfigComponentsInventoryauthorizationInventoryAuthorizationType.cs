using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryauthorizationInventoryAuthorizationType 
    {
        /// <summary>
        /// The version of the authorization model this configuration is applicable to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Service provider managed entities configuration of the vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service_provider_entities")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryauthorizationServiceProviderEntitiesType ServiceProviderEntities { get; set; }
    }
}
