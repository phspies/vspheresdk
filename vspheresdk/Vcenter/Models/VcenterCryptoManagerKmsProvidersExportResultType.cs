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
    public class VcenterCryptoManagerKmsProvidersExportResultType 
    {
        /// <summary>
        /// Type of provider export result
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterCryptoManagerKmsProvidersExportTypeEnum Type { get; set; }
        /// <summary>
        /// Location of the exported configuration
        /// This field is optional and it is only relevant when the value of Providers.ExportResult.type is LOCATION.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public VcenterCryptoManagerKmsProvidersLocationType Location { get; set; }
    }
}
