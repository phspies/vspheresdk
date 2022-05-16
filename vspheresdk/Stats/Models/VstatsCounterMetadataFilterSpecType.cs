using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Stats.Models.Enums;

namespace vspheresdk.Stats.Models
{
    public class VstatsCounterMetadataFilterSpecType 
    {
        /// <summary>
        /// Counter edition status. Warning: This attribute is available as Technology Preview. These are early access APIs provided
        /// to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When unset no filtering on counter metadata status will be made.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public VstatsCounterMetadataCounterEditionStatusType Status { get; set; }
    }
}
