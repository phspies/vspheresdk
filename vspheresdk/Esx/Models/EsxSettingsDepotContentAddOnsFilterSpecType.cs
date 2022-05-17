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
    public class EsxSettingsDepotContentAddOnsFilterSpecType 
    {
        /// <summary>
        /// Vendors that an add-on must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendors")]
        public IList<string> Vendors { get; set; }
        /// <summary>
        /// Names that an add-on must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Versions that an add-on must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<string> Versions { get; set; }
        /// <summary>
        /// Minimum version of an add-on that can match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_version")]
        public string? MinVersion { get; set; }
    }
}
