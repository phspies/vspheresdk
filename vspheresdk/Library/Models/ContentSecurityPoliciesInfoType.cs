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
    public class ContentSecurityPoliciesInfoType 
    {
        /// <summary>
        /// Identifier of the security policy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public string Policy { get; set; }
        /// <summary>
        /// Name of the security policy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Map of content library item type and rule types The rules can be associated with a security policy. When the security
        /// policy is applied to a content library, these rules will be used to validate specific item type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "item_type_rules", Required = Required.AllowNull)]
        public Dictionary<string,ContentSecurityRuleTypeEnum> ItemTypeRules { get; set; }
    }
}
