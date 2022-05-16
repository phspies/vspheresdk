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
    public class VcenterNamespaceManagementSoftwareClustersUpgradeType 
    {
        /// <summary>
        /// Version number the cluster is going to be upgraded to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_version", Required = Required.AllowNull)]
        public string DesiredVersion { get; set; }
        /// <summary>
        /// If true, the upgrade workflow will ignore any pre-check warnings and proceed with the upgrade.
        /// If unset, the upgrade workflow will not ignore pre-check warnings and fail the upgrade. It is equivalent to setting the
        /// value to false. The workflow adopts a conservative approach of failing the upgrade if unset to solely let the user
        /// decide whether to force the upgrade despite the warnings.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ignore_precheck_warnings")]
        public bool? IgnorePrecheckWarnings { get; set; }
    }
}
