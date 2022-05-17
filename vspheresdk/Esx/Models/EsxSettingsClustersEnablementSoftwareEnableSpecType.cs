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
    public class EsxSettingsClustersEnablementSoftwareEnableSpecType 
    {
        /// <summary>
        /// Skip {@link CheckType#SOFTWARE} check during feature enablement.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "skip_software_check", Required = Required.AllowNull)]
        public bool SkipSoftwareCheck { get; set; }
    }
}
