using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVmGuestFilesystemFilesFilterSpecType 
    {
        /// <summary>
        /// The perl-compatible regular expression used to filter the returned files.
        /// If unset the pattern '.*' (match everything) is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "match_pattern")]
        public string? MatchPattern { get; set; }
    }
}
