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
    public class VcenterNamespaceManagementStatsTimeSeriesTimeSeriesType 
    {
        /// <summary>
        /// Counter identifier.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "counter", Required = Required.AllowNull)]
        public string Counter { get; set; }
        /// <summary>
        /// Sequence of UNIX timestamp values at which statistical values were sampled. https://en.wikipedia.org/wiki/Unix_time
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time_stamps", Required = Required.AllowNull)]
        public long TimeStamps { get; set; }
        /// <summary>
        /// Sequence of sampled values corresponding to the timestamps in tss.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "values", Required = Required.AllowNull)]
        public long Values { get; set; }
    }
}
