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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryauthorizationServiceProviderEntitiesType 
    {
        /// <summary>
        /// List of full paths to the service provider managed entities inside the vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "entities", Required = Required.AllowNull)]
        public IList<string> Entities { get; set; }
        /// <summary>
        /// List of the inventory permissions to set inside the container.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryauthorizationPermissionType> Permissions { get; set; }
    }
}
