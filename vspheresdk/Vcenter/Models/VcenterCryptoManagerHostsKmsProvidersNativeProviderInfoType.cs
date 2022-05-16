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
    public class VcenterCryptoManagerHostsKmsProvidersNativeProviderInfoType 
    {
        /// <summary>
        /// Key identifier for the provider
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_id", Required = Required.AllowNull)]
        public string KeyId { get; set; }
    }
}
