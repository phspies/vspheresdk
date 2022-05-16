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
    public class VcenterCertificateManagementVcenterTlsRenewTypeA 
    {
        /// <summary>
        /// The duration (in days) of the new TLS certificate. The duration should be less than or equal to 730 days.
        /// If unset, the duration will be 730 days (two years).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }
    }
}
