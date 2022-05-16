using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVchaClusterErrorConditionType 
    {
        /// <summary>
        /// Contains an error condition.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Error { get; set; }
        /// <summary>
        /// Contains a recommendation on handling the error condition.
        /// If unset, there is no tip for the error condition.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "recommendation")]
        public VapiStdLocalizableMessageType Recommendation { get; set; }
    }
}
