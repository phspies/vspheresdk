using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentTypeInfoTypeA 
    {
        /// <summary>
        /// A description of the type support offered by the plugin.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// The name of the plugin which provides the type support.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The type which the plugin supports. <p> To upload a library item of the type supported by the plugin, the {@link
        /// ItemModel#type} {@term field} of the item should be set to this value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// The name of the vendor who created the type support plugin.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// The version number of the type support plugin.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// List of security rules which can be applied to this item type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported_rules")]
        public Dictionary<string,ContentSecurityRuleTypeA> SupportedRules { get; set; }
    }
}
