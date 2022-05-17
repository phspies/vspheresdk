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
    public class ApplianceRecoveryReconciliationJobInfoTypeA 
    {
        /// <summary>
        /// Description of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageTypeA Description { get; set; }
        /// <summary>
        /// Name of the service containing the operation.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.recovery.reconciliation.job. When operations return a value of this structure as a result, the field will be
        /// an identifier for the resource type: appliance.recovery.reconciliation.job.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service", Required = Required.AllowNull)]
        public string Service { get; set; }
        /// <summary>
        /// Name of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.AllowNull)]
        public string Operation { get; set; }
        /// <summary>
        /// Parent of the current task.
        /// This field will be unset if the task has no parent.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.recovery.reconciliation.job. When operations return a value of this structure as a result, the field will be
        /// an identifier for the resource type: appliance.recovery.reconciliation.job.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent")]
        public string? Parent { get; set; }
        /// <summary>
        /// Identifier of the target resource the operation modifies.
        /// This field will be unset if the task has multiple targets or no target.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public VapiStdDynamicIdtypeA Target { get; set; }
        /// <summary>
        /// Status of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceRecoveryReconciliationJobStatusEnumTypeA Status { get; set; }
        /// <summary>
        /// Flag to indicate whether or not the operation can be cancelled. The value may change as the operation progresses.
        /// If unset, the operation cannot be canceled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancelable")]
        public bool? Cancelable { get; set; }
        /// <summary>
        /// Description of the error if the operation status is "FAILED".
        /// If unset the description of why the operation failed will be included in the result of the operation (see Info#result).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Time when the operation is started.
        /// This field is optional and it is only relevant when the value of Job.Info.status is one of RUNNING, SUCCEEDED, or
        /// FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Time when the operation is completed.
        /// This field is optional and it is only relevant when the value of Job.Info.status is one of SUCCEEDED or FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// A list of localized messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageTypeA> Messages { get; set; }
        /// <summary>
        /// The progress of the job as a percentage.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress", Required = Required.AllowNull)]
        public long Progress { get; set; }
    }
}
