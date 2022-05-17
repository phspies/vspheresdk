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
    public class VstatsResourceAddressSchemasResourceIdDefinitionType 
    {
        /// <summary>
        /// Designates a semantic key for the resource identifier. This could be "vm" for virtual machine whose CPU usage is metered
        /// or "source" to identify the virtual machine that is origin of measured network traffic. Warning: This attribute is
        /// available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the
        /// feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends
        /// against using them in production environments. Some Technology Preview APIs might only be applicable to specific
        /// environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
        /// <summary>
        /// Type of the resource. This represents various entities for which statistical data is gathered such as virtual machines,
        /// containers, servers, disks etc. Warning: This attribute is available as Technology Preview. These are early access APIs
        /// provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not
        /// guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview
        /// APIs might only be applicable to specific environments.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vstats.model.RsrcType. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vstats.model.RsrcType.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// Designates the supported query-options. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "query_options", Required = Required.AllowNull)]
        public VstatsResourceAddressSchemasQueryCapabilitiesEnumType QueryOptions { get; set; }
    }
}
