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
    public class VcenterTokenserviceTokenExchangeExchangeType 
    {
        /// <summary>
        /// {@name ExchangeSpec} {@term structure} contains arguments that define exchange process.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterTokenserviceTokenExchangeExchangeSpecType Spec { get; set; }
    }
}
