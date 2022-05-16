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
    public class VapiStdErrorsAlreadyExistsErrorType 
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
        public VapiStdErrorsAlreadyExistsTypeA Value { get; set; }
    }
}
