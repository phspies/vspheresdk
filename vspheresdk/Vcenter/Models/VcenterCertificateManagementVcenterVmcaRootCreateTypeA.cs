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
    public class VcenterCertificateManagementVcenterVmcaRootCreateTypeA 
    {
        /// <summary>
        /// The information needed to generate VMCA signed Root Certificate.
        /// Default values will be set for all null parameters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public VcenterCertificateManagementVcenterVmcaRootCreateSpecTypeA Spec { get; set; }
    }
}
