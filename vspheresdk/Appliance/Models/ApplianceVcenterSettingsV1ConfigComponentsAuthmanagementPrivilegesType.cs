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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementPrivilegesType 
    {
        /// <summary>
        /// Privilege identifier.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// Privilege description.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Group to which the privilege belongs to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group", Required = Required.AllowNull)]
        public string Group { get; set; }
        /// <summary>
        /// does this apply to the parent entity?
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_on_parent", Required = Required.AllowNull)]
        public bool IsOnParent { get; set; }
    }
}
