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
    public class EsxSettingsClustersSoftwareDraftsSoftwareHardwareSupportSetType 
    {
        /// <summary>
        /// Map of Hardware Support Packages (HSPs) for the cluster.  The key is the Hardware Support Manager (HSM) name and the
        /// value is the specification detailing the HSP configured for that HSM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "packages", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHardwareSupportPackageSpecType> Packages { get; set; }
    }
}
