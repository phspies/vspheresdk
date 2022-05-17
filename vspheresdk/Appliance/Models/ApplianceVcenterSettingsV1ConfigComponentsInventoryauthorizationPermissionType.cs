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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryauthorizationPermissionType 
    {
        /// <summary>
        /// Full path to the entity for which the permission is set. The entity must be either one of the service provider managed
        /// entities, or a child thereof.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity", Required = Required.AllowNull)]
        public string Entity { get; set; }
        /// <summary>
        /// The principal for which the permission is set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "principal", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsAuthcommonPrincipalType Principal { get; set; }
        /// <summary>
        /// Name of a role in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_name", Required = Required.AllowNull)]
        public string RoleName { get; set; }
        /// <summary>
        /// Whether this permission propagates to child objects.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "propagate", Required = Required.AllowNull)]
        public bool Propagate { get; set; }
    }
}
