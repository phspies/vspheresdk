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
    public class VcenterVchaOperationsInfoType 
    {
        /// <summary>
        /// Identifiers of the operations that are current disabled. These operation strings are one of
        /// "vcenter.vcha.cluster.deploy", "vcenter.vcha.cluster.failover", "vcenter.vcha.cluster.passive.redeploy",
        /// "vcenter.vcha.cluster.witness.redeploy", "vcenter.vcha.cluster.mode.set", "vcenter.vcha.cluster.undeploy" and
        /// "vcenter.vcha.cluster.get".
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vapi.operation. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: vapi.operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disabled", Required = Required.AllowNull)]
        public IList<string> Disabled { get; set; }
        /// <summary>
        /// Identifiers of the operations that are currently running. These operation strings are one of
        /// "vcenter.vcha.cluster.deploy", "vcenter.vcha.cluster.failover", "vcenter.vcha.cluster.passive.redeploy",
        /// "vcenter.vcha.cluster.witness.redeploy", "vcenter.vcha.cluster.mode.set", and "vcenter.vcha.cluster.undeploy".
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vapi.operation. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: vapi.operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active", Required = Required.AllowNull)]
        public IList<string> Active { get; set; }
    }
}
