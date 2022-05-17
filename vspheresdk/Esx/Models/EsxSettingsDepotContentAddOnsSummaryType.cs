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
    public class EsxSettingsDepotContentAddOnsSummaryType 
    {
        /// <summary>
        /// Name of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Display name of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Vendor of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// Summary information about the versions of this addon. These are sorted by the version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsDepotContentAddOnsAddOnVersionSummaryType> Versions { get; set; }
    }
}
