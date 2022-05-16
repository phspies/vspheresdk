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
    public class VcenterCertificateManagementVcenterTrustedRootChainsSummaryTypeA 
    {
        /// <summary>
        /// Unique identifier for chain.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "chain", Required = Required.AllowNull)]
        public string Chain { get; set; }
    }
}
