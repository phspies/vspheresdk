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
    public class VcenterNamespaceManagementNsxtier0GatewaySummaryType 
    {
        /// <summary>
        /// Identifier of the Tier0 Gateway.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXTier0Gateway. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXTier0Gateway.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tier0_gateway", Required = Required.AllowNull)]
        public string Tier0Gateway { get; set; }
        /// <summary>
        /// Display name of the Tier0 Gateway.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
    }
}
