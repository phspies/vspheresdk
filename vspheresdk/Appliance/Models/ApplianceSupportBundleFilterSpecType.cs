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
    public class ApplianceSupportBundleFilterSpecType 
    {
        /// <summary>
        /// Filter only downloadable details.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool? Available { get; set; }
        /// <summary>
        /// Filter by task status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_status")]
        public ApplianceSupportBundleCreationStatusType CreationStatus { get; set; }
    }
}
