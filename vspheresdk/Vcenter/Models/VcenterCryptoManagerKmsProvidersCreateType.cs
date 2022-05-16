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
    public class VcenterCryptoManagerKmsProvidersCreateType 
    {
        /// <summary>
        /// Provider identifier.
        /// A unique string provided by the client.
        /// 
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.crypto_manager.kms.provider. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.crypto_manager.kms.provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public string Provider { get; set; }
        /// <summary>
        /// The constraints on the provider.
        /// If unset there are no constraints on the provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public VcenterCryptoManagerKmsProvidersConstraintsSpecType Constraints { get; set; }
        /// <summary>
        /// Native provider create spec.
        /// This field is required when creating a NATIVE provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "native_spec")]
        public VcenterCryptoManagerKmsProvidersNativeProviderCreateSpecType NativeSpec { get; set; }
    }
}
