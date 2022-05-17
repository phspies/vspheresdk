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
    public class VcenterHvcLinksSummaryTypeA 
    {
        /// <summary>
        /// Unique identifier for the link. *Warning:* This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "link", Required = Required.AllowNull)]
        public string Link { get; set; }
        /// <summary>
        /// The display name is set to the domain name which was set during create. *Warning:* This attribute is available as
        /// Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since
        /// this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them
        /// in production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
    }
}
