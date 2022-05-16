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
    public class VcenterCryptoManagerKmsProvidersImportResultType 
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
        /// Native provider information
        /// This field is optional and it is only relevant when the value of Providers.ImportResult.type is NATIVE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "native_info")]
        public VcenterCryptoManagerKmsProvidersNativeProviderInfoType NativeInfo { get; set; }
        /// <summary>
        /// Time when the provider was exported
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_time", Required = Required.AllowNull)]
        public DateTime ExportTime { get; set; }
        /// <summary>
        /// The constraints on the provider.
        /// If unset, there are no constraints on the provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public VcenterCryptoManagerKmsProvidersConstraintsType Constraints { get; set; }
    }
}
