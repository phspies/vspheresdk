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
    public class VcenterVchaClusterFailoverTaskTypeA 
    {
        /// <summary>
        /// If false, a failover is initiated immediately and may result in data loss.
        /// If true, a failover is initated after the Active node flushes its state to Passive and there is no data loss.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "planned", Required = Required.AllowNull)]
        public bool Planned { get; set; }
    }
}
