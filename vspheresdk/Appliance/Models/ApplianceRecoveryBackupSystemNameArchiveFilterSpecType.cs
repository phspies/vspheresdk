using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceRecoveryBackupSystemNameArchiveFilterSpecType 
    {
        /// <summary>
        /// Backup must have been taken on or after this time to match the filter.
        /// If unset the filter will match oldest backups.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_timestamp")]
        public DateTime? StartTimestamp { get; set; }
        /// <summary>
        /// Backup must have been taken on or before this time to match the filter.
        /// If unset the filter will match most recent backups.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_timestamp")]
        public DateTime? EndTimestamp { get; set; }
        /// <summary>
        /// Backup comment must contain this string to match the filter.
        /// If unset the filter will match backups with any comment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment_substring")]
        public string? CommentSubstring { get; set; }
        /// <summary>
        /// Limit result to a max count of most recent backups.
        /// If unset it defaults to 128.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "max_results")]
        public long? MaxResults { get; set; }
    }
}
