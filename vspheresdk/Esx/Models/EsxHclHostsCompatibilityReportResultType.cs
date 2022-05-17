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
    public class EsxHclHostsCompatibilityReportResultType 
    {
        /// <summary>
        /// The hardware compatibility report.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "report", Required = Required.AllowNull)]
        public EsxHclHostsCompatibilityReportHclReportType Report { get; set; }
        /// <summary>
        /// The identifier of the compatibility report. <p> {@link esx.hcl.Reports#get} provides location where a file based report
        /// based on the {@name HclReport} can be downloaded using this identifier.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string? Identifier { get; set; }
    }
}
