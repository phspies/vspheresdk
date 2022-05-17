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
    public class EsxSettingsDepotsHardwareSupportManagerSummaryType 
    {
        /// <summary>
        /// UI label for HSM, derived from HSM extension's description's 'label' field.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Different hardware support packages (HSP) published by the HSM. The key is name of HSP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "packages", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsDepotsHardwareSupportPackageSummaryType> Packages { get; set; }
    }
}
