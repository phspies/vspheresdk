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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryPermissionType 
    {
        /// <summary>
        /// User/Group name associated with the permission.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "principal", Required = Required.AllowNull)]
        public string Principal { get; set; }
        /// <summary>
        /// True if principal is a group.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group", Required = Required.AllowNull)]
        public bool Group { get; set; }
        /// <summary>
        /// True if permission can be propagated to child entities.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "propagate", Required = Required.AllowNull)]
        public bool Propagate { get; set; }
        /// <summary>
        /// Role associated with the permission.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "role_id", Required = Required.AllowNull)]
        public long RoleId { get; set; }
    }
}
