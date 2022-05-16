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
    public class VcenterCertificateManagementVcenterTlsCsrInfoType 
    {
        /// <summary>
        /// Certificate Signing Request in PEM format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "csr", Required = Required.AllowNull)]
        public string Csr { get; set; }
    }
}
