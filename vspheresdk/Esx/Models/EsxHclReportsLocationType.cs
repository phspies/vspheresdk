using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxHclReportsLocationType 
    {
        /// <summary>
        /// Compatibility report download URL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// Information about the token required in the HTTP GET request to download the compatibility report.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "report_token", Required = Required.AllowNull)]
        public EsxHclReportsTokenType ReportToken { get; set; }
    }
}
