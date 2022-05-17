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
    public class EsxSettingsDepotContentComponentsFilterSpecType 
    {
        /// <summary>
        /// Vendors that a component must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendors")]
        public IList<string> Vendors { get; set; }
        /// <summary>
        /// Names that a component must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Versions that a component must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions")]
        public IList<string> Versions { get; set; }
        /// <summary>
        /// Minimum version of the component that can match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_version")]
        public string? MinVersion { get; set; }
        /// <summary>
        /// Component bundle types that a component must have to match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bundle_types")]
        public Dictionary<string,EsxSettingsDepotContentComponentsComponentBundleType> BundleTypes { get; set; }
    }
}
