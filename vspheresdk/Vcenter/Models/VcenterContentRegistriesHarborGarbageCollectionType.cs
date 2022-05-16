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
    public class VcenterContentRegistriesHarborGarbageCollectionType 
    {
        /// <summary>
        /// Frequency of garbage collection.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterContentRegistriesRecurrenceType Type { get; set; }
        /// <summary>
        /// Day of the week when garbage collection should run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "day_of_week")]
        public VcenterContentRegistriesDayOfWeekType DayOfWeek { get; set; }
        /// <summary>
        /// Hour at which garbage collection should run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public long? Hour { get; set; }
        /// <summary>
        /// Minute at which garbage collection should run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public long? Minute { get; set; }
    }
}
