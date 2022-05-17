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
    public class VapiStdErrorsNotAllowedInCurrentStateErrorType 
    {
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public VapiStdErrorsNotAllowedInCurrentStateTypeA Value { get; set; }
    }
}
