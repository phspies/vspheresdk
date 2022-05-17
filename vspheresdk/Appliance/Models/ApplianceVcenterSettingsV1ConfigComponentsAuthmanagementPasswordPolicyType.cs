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
    public class ApplianceVcenterSettingsV1ConfigComponentsAuthmanagementPasswordPolicyType 
    {
        /// <summary>
        /// Minimum special characters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "special_chars", Required = Required.AllowNull)]
        public long SpecialChars { get; set; }
        /// <summary>
        /// Minimum alphabetic characters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "alpha_chars", Required = Required.AllowNull)]
        public long AlphaChars { get; set; }
        /// <summary>
        /// Minimum uppercase characters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "uppercase_chars", Required = Required.AllowNull)]
        public long UppercaseChars { get; set; }
        /// <summary>
        /// Minimum lowercase characters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "lowercase_chars", Required = Required.AllowNull)]
        public long LowercaseChars { get; set; }
        /// <summary>
        /// Minimum numeric characters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "numeric_chars", Required = Required.AllowNull)]
        public long NumericChars { get; set; }
        /// <summary>
        /// Maximum adjacent identical characters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "adj_identical_chars", Required = Required.AllowNull)]
        public long AdjIdenticalChars { get; set; }
        /// <summary>
        /// Previous password reuse restriction.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password_reuse", Required = Required.AllowNull)]
        public long PasswordReuse { get; set; }
        /// <summary>
        /// Maximum lifetime.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_life", Required = Required.AllowNull)]
        public long MaxLife { get; set; }
        /// <summary>
        /// Maximum length.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_length", Required = Required.AllowNull)]
        public long MaxLength { get; set; }
        /// <summary>
        /// Minimum length.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_length", Required = Required.AllowNull)]
        public long MinLength { get; set; }
    }
}
