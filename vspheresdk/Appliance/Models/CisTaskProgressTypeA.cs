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
    public class CisTaskProgressTypeA 
    {
        /// <summary>
        /// Total amount of the work for the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "total", Required = Required.AllowNull)]
        public long Total { get; set; }
        /// <summary>
        /// The amount of work completed for the operation. The value can only be incremented.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "completed", Required = Required.AllowNull)]
        public long Completed { get; set; }
        /// <summary>
        /// Message about the work progress.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageTypeA Message { get; set; }
    }
}
