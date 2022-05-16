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
    public class VcenterDeploymentImportHistoryStartTypeA 
    {
        /// <summary>
        /// An optional ImportHistory.CreateSpec info that can be passed for creating a new historical data import task and starts
        /// it.
        /// If unset, default value will be:
        /// - name : vcenter.deployment.history.import
        /// - description : vCenter Server history import
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public VcenterDeploymentImportHistoryCreateSpecTypeA Spec { get; set; }
    }
}
