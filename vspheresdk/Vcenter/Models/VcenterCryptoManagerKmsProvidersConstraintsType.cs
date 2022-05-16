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
    public class VcenterCryptoManagerKmsProvidersConstraintsType 
    {
        /// <summary>
        /// Determines if a provider is restricted to hosts with TPM 2.0 capability.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tpm_required", Required = Required.AllowNull)]
        public bool TpmRequired { get; set; }
    }
}
