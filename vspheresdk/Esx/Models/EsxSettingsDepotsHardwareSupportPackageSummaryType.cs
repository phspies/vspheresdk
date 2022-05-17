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
    public class EsxSettingsDepotsHardwareSupportPackageSummaryType 
    {
        /// <summary>
        /// Different versions of the HSP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsDepotsHardwareSupportPackageVersionType> Versions { get; set; }
    }
}
