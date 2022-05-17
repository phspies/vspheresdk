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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementGlobalPermissionType 
    {
        /// <summary>
        /// Principal with roles.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "principal", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsAuthcommonPrincipalType Principal { get; set; }
        /// <summary>
        /// Role Names assigned to this Principal
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_names", Required = Required.AllowNull)]
        public IList<string> RoleNames { get; set; }
        /// <summary>
        /// Propagating to child objects.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "propagate", Required = Required.AllowNull)]
        public bool Propagate { get; set; }
    }
}
