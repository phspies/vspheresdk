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
    public class VcenterVchaClusterPassiveCheckResultType 
    {
        /// <summary>
        /// A list of problems which may require attention, but which are not fatal.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Warnings { get; set; }
        /// <summary>
        /// A list of problems which are fatal to the operation and the operation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Errors { get; set; }
    }
}
