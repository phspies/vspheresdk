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
    public class EsxSettingsClustersSoftwareDraftsCommitSpecType 
    {
        /// <summary>
        /// Message to include with the commit.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
    }
}
