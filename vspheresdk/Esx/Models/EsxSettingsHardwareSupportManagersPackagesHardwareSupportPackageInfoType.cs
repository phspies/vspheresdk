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
    public class EsxSettingsHardwareSupportManagersPackagesHardwareSupportPackageInfoType 
    {
        /// <summary>
        /// Name of the Hardware Support Package (e.g. "Jan. 2018 Release" or "Latest Hardware Support Package for Frobozz GenX
        /// hardware") selected
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pkg", Required = Required.AllowNull)]
        public string Pkg { get; set; }
        /// <summary>
        /// Version of the Hardware Support Package (e.g. "20180128.1" or "v42") selected
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Description of the Hardware Support Package (HSP) (e.g. for use in help bubble)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Supported vSphere releases
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported_releases", Required = Required.AllowNull)]
        public IList<string> SupportedReleases { get; set; }
    }
}
