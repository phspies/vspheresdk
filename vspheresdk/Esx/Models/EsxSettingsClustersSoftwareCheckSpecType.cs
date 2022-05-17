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
    public class EsxSettingsClustersSoftwareCheckSpecType 
    {
        /// <summary>
        /// The minimum commit identifier of the desired software document to be used during the check {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string? Commit { get; set; }
        /// <summary>
        /// The specific hosts for which checks need to be performed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
    }
}
