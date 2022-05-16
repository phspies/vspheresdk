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
    public class VcenterCryptoManagerKmsProvidersSummaryType 
    {
        /// <summary>
        /// Provider identifier
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.crypto_manager.kms.provider. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.crypto_manager.kms.provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public string Provider { get; set; }
        /// <summary>
        /// Provider type
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterCryptoManagerKmsProvidersType Type { get; set; }
        /// <summary>
        /// Health status of the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health", Required = Required.AllowNull)]
        public VcenterCryptoManagerKmsProvidersHealthType Health { get; set; }
    }
}
