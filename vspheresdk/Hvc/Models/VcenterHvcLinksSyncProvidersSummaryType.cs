using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Hvc.Models.Enums;

namespace vspheresdk.Hvc.Models
{
    public class VcenterHvcLinksSyncProvidersSummaryType 
    {
        /// <summary>
        /// Sync provider id *Warning:* This attribute is available as Technology Preview. These are early access APIs provided to
        /// test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public string Provider { get; set; }
    }
}
