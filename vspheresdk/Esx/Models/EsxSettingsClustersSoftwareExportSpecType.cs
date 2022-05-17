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
    public class EsxSettingsClustersSoftwareExportSpecType 
    {
        /// <summary>
        /// Whether to export software specification document.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_software_spec", Required = Required.AllowNull)]
        public bool ExportSoftwareSpec { get; set; }
        /// <summary>
        /// Whether to export ISO image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_iso_image", Required = Required.AllowNull)]
        public bool ExportIsoImage { get; set; }
        /// <summary>
        /// Whether to export offline bundle.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "export_offline_bundle", Required = Required.AllowNull)]
        public bool ExportOfflineBundle { get; set; }
    }
}
