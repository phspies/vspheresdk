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
    public class VcenterNamespacesAccessInfoType 
    {
        /// <summary>
        /// Role of the subject on the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "role", Required = Required.AllowNull)]
        public VcenterNamespacesAccessRoleEnumType Role { get; set; }
        /// <summary>
        /// Flag to indicate if the Access.Info.role is direct or inherited. The value is set to true if the Access.Info.role is
        /// inherited from group membership
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "inherited")]
        public bool? Inherited { get; set; }
    }
}
