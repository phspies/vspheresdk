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
    public class ApplianceSystemTimeSystemTimeStructType 
    {
        /// <summary>
        /// seconds since the epoch
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "seconds_since_epoch", Required = Required.AllowNull)]
        public double SecondsSinceEpoch { get; set; }
        /// <summary>
        /// date format: Thu 07-31-2014
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "date", Required = Required.AllowNull)]
        public string Date { get; set; }
        /// <summary>
        /// time format: 18:18:32
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time", Required = Required.AllowNull)]
        public string Time { get; set; }
        /// <summary>
        /// timezone
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezone", Required = Required.AllowNull)]
        public string Timezone { get; set; }
    }
}
