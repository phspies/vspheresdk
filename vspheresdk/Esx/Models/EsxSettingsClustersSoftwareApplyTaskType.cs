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
    public class EsxSettingsClustersSoftwareApplyTaskType 
    {
        /// <summary>
        /// The minimum commit identifier of the desired software document to be used during the {@link
        /// esx.settings.clusters.Software#apply} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string? Commit { get; set; }
        /// <summary>
        /// The specific hosts within the cluster to be considered during the {@link esx.settings.clusters.Software#apply} {@term
        /// operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// Accept the VMware End User License Agreement (EULA) before starting the {@link esx.settings.clusters.Software#apply}
        /// {@term operation}. The VMware EULA is available for download at, https://www.vmware.com/download/eula.html
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "accept_eula")]
        public bool? AcceptEula { get; set; }
    }
}
