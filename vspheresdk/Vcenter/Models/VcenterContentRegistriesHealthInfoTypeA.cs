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
    public class VcenterContentRegistriesHealthInfoTypeA 
    {
        /// <summary>
        /// Container registry status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterContentRegistriesHealthStatusTypeA Status { get; set; }
        /// <summary>
        /// Details about the status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public VapiStdLocalizableMessageTypeA Details { get; set; }
    }
}
