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
    public class EsxSettingsClustersSoftwareCommitsInfoType 
    {
        /// <summary>
        /// Author of the commit.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "author", Required = Required.AllowNull)]
        public string Author { get; set; }
        /// <summary>
        /// Creation time of the commit.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit_time", Required = Required.AllowNull)]
        public DateTime CommitTime { get; set; }
        /// <summary>
        /// Description accompanying this commit.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Apply status of the commit.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "apply_status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareCommitsInfoApplyStatusTypeEnum ApplyStatus { get; set; }
    }
}
