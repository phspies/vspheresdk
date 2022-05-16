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
    public class VcenterCertificateManagementVcenterTlsCsrCreateTypeA 
    {
        /// <summary>
        /// The information needed to create a CSR.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterCertificateManagementVcenterTlsCsrSpecTypeA Spec { get; set; }
    }
}
