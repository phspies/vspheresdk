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
    public class VapiStdLocalizableMessageType 
    {
        /// <summary>
        /// Unique identifier of the localizable string or message template. <p> This identifier is typically used to retrieve a
        /// locale-specific string or message template from a message catalog.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The value of this localizable string or message template in the {@code en_US} (English) locale.  If {@link #id} refers
        /// to a message template, the default message will contain the substituted arguments. This value can be used by clients
        /// that do not need to display strings and messages in the native language of the user.  It could also be used as a
        /// fallback if a client is unable to access the appropriate message catalog.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_message", Required = Required.AllowNull)]
        public string DefaultMessage { get; set; }
        /// <summary>
        /// Positional arguments to be substituted into the message template. This list will be empty if the message uses named
        /// arguments or has no arguments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "args", Required = Required.AllowNull)]
        public IList<string> Args { get; set; }
        /// <summary>
        /// Named arguments to be substituted into the message template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public Dictionary<string,VapiStdLocalizationParamType>? Params { get; set; }
        /// <summary>
        /// Localized string value as per request requirements.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "localized")]
        public string? Localized { get; set; }
    }
}
