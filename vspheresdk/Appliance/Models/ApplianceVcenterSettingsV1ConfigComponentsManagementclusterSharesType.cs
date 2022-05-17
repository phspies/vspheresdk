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
    public class ApplianceVcenterSettingsV1ConfigComponentsManagementclusterSharesType 
    {
        /// <summary>
        /// The allocation level. It maps to a pre-determined set of numeric values for shares. If the shares value does not map to
        /// a predefined size, then the level is set as CUSTOM. Warning: This attribute is available as Technology Preview. These
        /// are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterSharesLevelEnumType Level { get; set; }
        /// <summary>
        /// When Shares.level is set to CUSTOM, it is the number of shares allocated. Otherwise, this value is ignored.
        /// There is no unit for this value. It is a relative measure based on the settings for other resource pools.
        /// . Warning: This attribute is available as Technology Preview. These are early access APIs provided to test, automate and
        /// provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards
        /// compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be
        /// applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares", Required = Required.AllowNull)]
        public long Shares { get; set; }
    }
}
