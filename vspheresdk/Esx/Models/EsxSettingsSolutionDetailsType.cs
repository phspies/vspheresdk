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
    public class EsxSettingsSolutionDetailsType 
    {
        /// <summary>
        /// Display name of the solution.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Display version of the solution.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// Components registered by the solution. If the component is not present in the depot, then corresponding details are
        /// absent from the list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsSolutionComponentDetailsType> Components { get; set; }
    }
}
