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
    public class ApplianceUpdatePendingQuestionType 
    {
        /// <summary>
        /// ID of the data item
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// applicance.update.pending.dataitem. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: applicance.update.pending.dataitem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "data_item", Required = Required.AllowNull)]
        public string DataItem { get; set; }
        /// <summary>
        /// Label for the item to be used in GUI/CLI
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "text", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Text { get; set; }
        /// <summary>
        /// Description of the item
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
        /// <summary>
        /// How this field shoudl be represented in GUI or CLI
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public ApplianceUpdatePendingQuestionInputType Type { get; set; }
        /// <summary>
        /// List of allowed values
        /// allowedValues If unset any value is valid.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowed_values")]
        public IList<string> AllowedValues { get; set; }
        /// <summary>
        /// Regexp to validate the input
        /// regexp If unset no validation will be performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "regexp")]
        public string? Regexp { get; set; }
        /// <summary>
        /// Default answer
        /// defaultAnswer If unset then there is no default answer, so an explicit answer must be provided
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_answer")]
        public string? DefaultAnswer { get; set; }
    }
}
