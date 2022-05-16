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
    public class VcenterContentRegistriesHarborCreateTypeA 
    {
        /// <summary>
        /// A unique token generated on the client for each creation request. The token should be a universally unique identifier
        /// (UUID), for example: {@code b8a2a2e3-2314-43cd-a871-6ede0f429751}. This token can be used to guarantee idempotent
        /// creation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_token")]
        public string? ClientToken { get; set; }
        /// <summary>
        /// Specification for creating the Harbor registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterContentRegistriesHarborCreateSpecTypeA Spec { get; set; }
    }
}
