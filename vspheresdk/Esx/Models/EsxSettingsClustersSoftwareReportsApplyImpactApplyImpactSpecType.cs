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
    public class EsxSettingsClustersSoftwareReportsApplyImpactApplyImpactSpecType 
    {
        /// <summary>
        /// The specific hosts for which an impact is to be generated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
    }
}
