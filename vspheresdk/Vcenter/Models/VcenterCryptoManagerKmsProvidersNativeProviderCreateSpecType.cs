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
    public class VcenterCryptoManagerKmsProvidersNativeProviderCreateSpecType 
    {
        /// <summary>
        /// Key identifier for the provider.
        /// The key identifier is required to be a 128-bit UUID represented as a hexadecimal string in
        /// "12345678-abcd-1234-cdef-123456789abc" format.
        /// 
        /// If unset, the key identifier will be generated automatically.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_id")]
        public string? KeyId { get; set; }
        /// <summary>
        /// Key used to derive data encryption keys. Base64 encoded.
        /// If unset, the key derivation key will be generated automatically.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_derivation_key")]
        public string? KeyDerivationKey { get; set; }
    }
}
