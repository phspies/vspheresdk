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
    public class EsxHclHostsCompatibilityReportCreateTaskType 
    {
        /// <summary>
        /// A target ESXi release which will be used to generate a compatibility report. Releases that can be used to generate
        /// report can be found using {@link esx.hcl.hosts.CompatibilityReleases#list}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release", Required = Required.AllowNull)]
        public string Release { get; set; }
    }
}
