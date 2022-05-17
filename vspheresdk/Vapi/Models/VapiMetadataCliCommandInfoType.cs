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
    public class VapiMetadataCliCommandInfoType 
    {
        /// <summary>
        /// Basic command identity.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity", Required = Required.AllowNull)]
        public VapiMetadataCliCommandIdentityType Identity { get; set; }
        /// <summary>
        /// The text description displayed to the user in help output.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// The service identifier that contains the operations for this CLI command.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service_id", Required = Required.AllowNull)]
        public string ServiceId { get; set; }
        /// <summary>
        /// The operation identifier corresponding to this CLI command.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operation_id", Required = Required.AllowNull)]
        public string OperationId { get; set; }
        /// <summary>
        /// The input for this command.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "options", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataCliCommandOptionInfoType> Options { get; set; }
        /// <summary>
        /// The formatter to use when displaying the output of this command.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "formatter")]
        public VapiMetadataCliCommandFormatterTypeEnum Formatter { get; set; }
        /// <summary>
        /// List of output structure name and output field info.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "output_field_list", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataCliCommandOutputInfoType> OutputFieldList { get; set; }
    }
}
