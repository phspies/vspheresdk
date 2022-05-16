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
    public class VcenterCertificateManagementVcenterTlsReplaceVmcaSignedTypeA 
    {
        /// <summary>
        /// The information needed to generate VMCA signed Machine SSL
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterCertificateManagementVcenterTlsReplaceSpecTypeA Spec { get; set; }
    }
}
