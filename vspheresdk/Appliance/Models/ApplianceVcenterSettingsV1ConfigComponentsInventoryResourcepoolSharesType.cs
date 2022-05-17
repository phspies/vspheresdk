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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolSharesType 
    {
        /// <summary>
        /// The allocation level. It maps to a pre-determined set of numeric values for shares. If the shares value does not map to
        /// a predefined size, then the level is set as CUSTOM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolSharesLevelEnumType Level { get; set; }
        /// <summary>
        /// When Shares.level is set to CUSTOM, it is the number of shares allocated. Otherwise, this value is ignored.
        /// There is no unit for this value. It is a relative measure based on the settings for other resource pools.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares", Required = Required.AllowNull)]
        public long Shares { get; set; }
    }
}
