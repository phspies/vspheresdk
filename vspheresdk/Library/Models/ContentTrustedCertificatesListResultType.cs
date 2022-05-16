using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentTrustedCertificatesListResultType 
    {
        /// <summary>
        /// List of certificates.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificates", Required = Required.AllowNull)]
        public Dictionary<string,ContentTrustedCertificatesSummaryType> Certificates { get; set; }
    }
}
