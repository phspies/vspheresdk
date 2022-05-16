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
    public class VcenterDeploymentCheckInfoType 
    {
        /// <summary>
        /// Status of the check.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterDeploymentCheckStatusType Status { get; set; }
        /// <summary>
        /// Result of the check.
        /// This field will be unset if result is not available at the current step of the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public VcenterDeploymentNotificationsType Result { get; set; }
        /// <summary>
        /// Information collected from the source machine.
        /// This field is used only for upgrade and migrate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_info")]
        public VcenterDeploymentSourceInfoType SourceInfo { get; set; }
    }
}
