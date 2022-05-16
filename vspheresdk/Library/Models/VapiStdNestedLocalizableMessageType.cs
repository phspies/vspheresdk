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
    public class VapiStdNestedLocalizableMessageType 
    {
        /// <summary>
        /// Unique identifier of the localizable string or message template. <p> This identifier is typically used to retrieve a
        /// locale-specific string or message template from a message catalog.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// Named Arguments to be substituted into the message template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public Dictionary<string,VapiStdLocalizationParamType>? Params { get; set; }
    }
}
