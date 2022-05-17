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
    public class VcenterCryptoManagerKmsProvidersFilterSpecType 
    {
        /// <summary>
        /// Provider identifiers.
        /// If unset or empty, the result will not be filtered by provider identifier.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.crypto_manager.kms.provider. When operations return a value of this structure as a result, the field will
        /// contain identifiers for the resource type: vcenter.crypto_manager.kms.provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<string> Providers { get; set; }
        /// <summary>
        /// Provider health status.
        /// If unset or empty, the result will not be filtered by provider health status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public Dictionary<string,VcenterCryptoManagerKmsProvidersHealthEnumType> Health { get; set; }
    }
}
