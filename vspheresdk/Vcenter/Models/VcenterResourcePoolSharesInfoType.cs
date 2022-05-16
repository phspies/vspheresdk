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
    public class VcenterResourcePoolSharesInfoType 
    {
        /// <summary>
        /// The allocation level. It maps to a pre-determined set of numeric values for shares. If the shares value does not map to
        /// a predefined size, then the level is set as CUSTOM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "level", Required = Required.AllowNull)]
        public VcenterResourcePoolSharesInfoLevelType Level { get; set; }
        /// <summary>
        /// When ResourcePool.SharesInfo.level is set to CUSTOM, it is the number of shares allocated. Otherwise, this value is
        /// ignored.
        /// There is no unit for this value. It is a relative measure based on the settings for other resource pools.
        /// 
        /// This field is optional and it is only relevant when the value of ResourcePool.SharesInfo.level is CUSTOM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "shares")]
        public long? Shares { get; set; }
    }
}
