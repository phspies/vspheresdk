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
    public class VcenterCertificateManagementVcenterSigningCertificateRefreshType 
    {
        /// <summary>
        /// Will force refresh in environments that would otherwise prevent refresh from occurring, such as a mixed-version
        /// environment. Force refresh may leave systems in the local vCenter domain in a non-functional state until they are
        /// restarted.
        /// If unset, then refresh will not be forced.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }
    }
}
