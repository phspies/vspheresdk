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
    public class EsxSettingsHardwareSupportPackageInfoType 
    {
        /// <summary>
        /// Identifier of Hardware Support Package (HSP) selected
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pkg", Required = Required.AllowNull)]
        public string Pkg { get; set; }
        /// <summary>
        /// Version of the Hardware Support Package (HSP) selected (e.g. "20180128.1" or "v42")
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
    }
}
