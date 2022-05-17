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
    public class ApplianceSupportBundleIterationSpecType 
    {
        /// <summary>
        /// Size specifies the maximum number of results to return.
        /// If unset defaults to 50.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
    }
}
