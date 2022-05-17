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
    public class EsxSettingsClustersEnablementSoftwareCheckTaskType 
    {
        /// <summary>
        /// Specifies the checks that should be skipped. If the {@term set} is empty, all checks will be performed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "checks_to_skip", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersEnablementSoftwareCheckTypeEnum> ChecksToSkip { get; set; }
    }
}
