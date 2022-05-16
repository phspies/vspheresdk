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
    public class VcenterCryptoManagerKmsProvidersUpdateType 
    {
        /// <summary>
        /// New Configuration for NATIVE provider.
        /// 
        /// 
        /// If unset, provider configuration will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "native_spec")]
        public VcenterCryptoManagerKmsProvidersNativeProviderUpdateSpecType NativeSpec { get; set; }
    }
}
