using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiMetadataCliCommandOptionInfoTypeA 
    {
        /// <summary>
        /// The long option name of the parameter as used by the user.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "long_option", Required = Required.AllowNull)]
        public string LongOption { get; set; }
        /// <summary>
        /// The single character value option name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "short_option")]
        public string? ShortOption { get; set; }
        /// <summary>
        /// The fully qualified name of the option referred to by the operation element in {@link Info#operationId}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "field_name", Required = Required.AllowNull)]
        public string FieldName { get; set; }
        /// <summary>
        /// The description of the option to be displayed to the user when they request usage information for a CLI command.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// The type of option. This is used to display information about what kind of data is expected (string, number, boolean,
        /// etc.) for the option when they request usage information for a CLI command. For {@term enumerated type} this stores the
        /// fully qualified {@term enumerated type} id.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// This is used to tell the user whether the option is required or optional, or whether they can specify the option
        /// multiple times.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "generic", Required = Required.AllowNull)]
        public VapiMetadataCliCommandGenericTypeA Generic { get; set; }
    }
}
