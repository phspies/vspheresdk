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
    public class EsxHclHostsCompatibilityReleasesEsxiCompatibilityReleasesType 
    {
        /// <summary>
        /// The current release of the ESXi, which also can be checked for compatibility. <p> The information for the release does
        /// not include patch information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_compatibility_release", Required = Required.AllowNull)]
        public string CurrentCompatibilityRelease { get; set; }
        /// <summary>
        /// The available ESXi releases, greater than the current one, than can be checked for compatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "newer_compatibility_releases", Required = Required.AllowNull)]
        public IList<string> NewerCompatibilityReleases { get; set; }
        /// <summary>
        /// Notifications returned by the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxHclNotificationsType Notifications { get; set; }
    }
}
