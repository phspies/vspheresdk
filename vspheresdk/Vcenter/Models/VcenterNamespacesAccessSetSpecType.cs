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
    public class VcenterNamespacesAccessSetSpecType 
    {
        /// <summary>
        /// Role to be assigned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "role", Required = Required.AllowNull)]
        public VcenterNamespacesAccessRoleType Role { get; set; }
    }
}
