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
    public class VcenterContentRegistriesHealthInfoType 
    {
        /// <summary>
        /// Container registry status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterContentRegistriesHealthStatusType Status { get; set; }
        /// <summary>
        /// Details about the status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public VapiStdLocalizableMessageType Details { get; set; }
    }
}
