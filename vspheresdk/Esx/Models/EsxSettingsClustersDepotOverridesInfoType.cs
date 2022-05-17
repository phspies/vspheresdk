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
    public class EsxSettingsClustersDepotOverridesInfoType 
    {
        /// <summary>
        /// List of the depot overrides.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "depots", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersDepotOverridesAddType> Depots { get; set; }
    }
}
