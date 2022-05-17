using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Models
{
    public class CisTaggingTagAssociationBatchResultType 
    {
        /// <summary>
        /// This is true if the batch operation completed without any errors. Otherwise it is false and all or some operations have
        /// failed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "success", Required = Required.AllowNull)]
        public bool Success { get; set; }
        /// <summary>
        /// The list of error messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_messages", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> ErrorMessages { get; set; }
    }
}
