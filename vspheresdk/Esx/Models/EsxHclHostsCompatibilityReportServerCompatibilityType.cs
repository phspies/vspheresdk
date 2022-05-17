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
    public class EsxHclHostsCompatibilityReportServerCompatibilityType 
    {
        /// <summary>
        /// Lists the BIOS constraints that the target ESXi release has for this server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios_constraints")]
        public Dictionary<string,EsxHclHostsCompatibilityReportBiosConstraintType> BiosConstraints { get; set; }
        /// <summary>
        /// The CPU series name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_series", Required = Required.AllowNull)]
        public string CpuSeries { get; set; }
        /// <summary>
        /// Provides information about supported releases for this entry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported_releases")]
        public IList<string> SupportedReleases { get; set; }
        /// <summary>
        /// Provides link to the VMware Compatibility Guide for further information on the compatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcg_link", Required = Required.AllowNull)]
        public string VcgLink { get; set; }
        /// <summary>
        /// Information that needs to be taken into account when considering this server hardware compatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public Dictionary<string,VapiStdLocalizableMessageType> Notes { get; set; }
    }
}
