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
    public class VcenterCryptoManagerHostsKmsProvidersInfoType 
    {
        /// <summary>
        /// Health status of the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health", Required = Required.AllowNull)]
        public VcenterCryptoManagerHostsKmsProvidersHealthEnumType Health { get; set; }
        /// <summary>
        /// Details regarding the health status of the provider.
        /// When the provider Providers.Health is not OK or NONE, this field will provide actionable descriptions of the issues.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Details { get; set; }
        /// <summary>
        /// Provider type
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterCryptoManagerHostsKmsProvidersTypeEnum Type { get; set; }
        /// <summary>
        /// Native provider information
        /// This field is optional and it is only relevant when the value of Providers.Info.type is NATIVE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "native_info")]
        public VcenterCryptoManagerHostsKmsProvidersNativeProviderInfoType NativeInfo { get; set; }
    }
}
