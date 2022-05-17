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
    public class ApplianceMonitoringMonitoredItemDataType 
    {
        /// <summary>
        /// Monitored item IDs Ex: CPU, MEMORY, STORAGE_TOTAL
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.monitoring. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: appliance.monitoring.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// interval between values in hours, minutes
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interval", Required = Required.AllowNull)]
        public ApplianceMonitoringIntervalType Interval { get; set; }
        /// <summary>
        /// aggregation function
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "function", Required = Required.AllowNull)]
        public ApplianceMonitoringFunctionType Function { get; set; }
        /// <summary>
        /// Start time in UTC
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time", Required = Required.AllowNull)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// End time in UTC
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time", Required = Required.AllowNull)]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// list of values
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "data", Required = Required.AllowNull)]
        public IList<string> Data { get; set; }
    }
}
