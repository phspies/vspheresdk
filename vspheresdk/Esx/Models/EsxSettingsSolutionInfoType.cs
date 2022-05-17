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
    public class EsxSettingsSolutionInfoType 
    {
        /// <summary>
        /// Details about the solution from the depot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public EsxSettingsSolutionDetailsType Details { get; set; }
        /// <summary>
        /// Version of the solution.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Components registered by the solution.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsSolutionComponentSpecType> Components { get; set; }
    }
}
