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
    public class VcenterCryptoManagerKmsProvidersInfoType 
    {
        /// <summary>
        /// Health status of the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health", Required = Required.AllowNull)]
        public VcenterCryptoManagerKmsProvidersHealthEnumType Health { get; set; }
        /// <summary>
        /// Details regarding the health status of the provider.
        /// When the provider Providers.Health is not NONE or OK, this field will provide actionable descriptions of the issues.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Details { get; set; }
        /// <summary>
        /// The constraints on the provider.
        /// If unset, there are no constraints on the provider.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public VcenterCryptoManagerKmsProvidersConstraintsType Constraints { get; set; }
        /// <summary>
        /// Provider type
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterCryptoManagerKmsProvidersTypeEnum Type { get; set; }
        /// <summary>
        /// Native provider information
        /// This field is optional and it is only relevant when the value of Providers.Info.type is NATIVE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "native_info")]
        public VcenterCryptoManagerKmsProvidersNativeProviderInfoType NativeInfo { get; set; }
    }
}
