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
    public class VapiMetadataPrivilegeServiceOperationGetType 
    {
        /// <summary>
        /// Identifier of the operation element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operation_id", Required = Required.AllowNull)]
        public string OperationId { get; set; }
    }
}
