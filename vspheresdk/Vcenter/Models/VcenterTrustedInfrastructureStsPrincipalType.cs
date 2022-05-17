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
    public class VcenterTrustedInfrastructureStsPrincipalType 
    {
        /// <summary>
        /// The principal's ID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureStsPrincipalIdType Id { get; set; }
        /// <summary>
        /// The type of the principal (user or group).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureStsPrincipalTypeEnum Type { get; set; }
    }
}
