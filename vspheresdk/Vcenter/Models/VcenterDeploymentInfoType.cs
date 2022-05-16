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
    public class VcenterDeploymentInfoType 
    {
        /// <summary>
        /// State of the vCenter Server Appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterDeploymentApplianceStateType State { get; set; }
        /// <summary>
        /// The progress info of the current appliance status.
        /// This field is optional and it is only relevant when the value of CommonInfo#status is one of RUNNING, BLOCKED,
        /// SUCCEEDED, or FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public CisTaskProgressType Progress { get; set; }
        /// <summary>
        /// The ordered list of subtasks for this deployment operation.
        /// Only set when the appliance state is RUNNING_IN_PROGRESS, FAILED, CANCELLED and SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subtask_order")]
        public IList<string> SubtaskOrder { get; set; }
        /// <summary>
        /// The map of the deployment subtasks and their status infomation.
        /// Only set when the appliance state is RUNNING_IN_PROGRESS, FAILED, CANCELLED and SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subtasks")]
        public Dictionary<string,VcenterDeploymentTaskType>? Subtasks { get; set; }
        /// <summary>
        /// Description of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
        /// <summary>
        /// Identifier of the service containing the operation.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vapi.service. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: vapi.service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service", Required = Required.AllowNull)]
        public string Service { get; set; }
        /// <summary>
        /// Identifier of the operation associated with the task.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vapi.operation. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: vapi.operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operation", Required = Required.AllowNull)]
        public string Operation { get; set; }
        /// <summary>
        /// Parent of the current task.
        /// This field will be unset if the task has no parent.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// cis.task. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: cis.task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent")]
        public string? Parent { get; set; }
        /// <summary>
        /// Identifier of the target created by the operation or an existing one the operation performed on.
        /// This field will be unset if the operation has no target or multiple targets.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public VapiStdDynamicIdtype Target { get; set; }
        /// <summary>
        /// Status of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public CisTaskStatusType Status { get; set; }
        /// <summary>
        /// Flag to indicate whether or not the operation can be cancelled. The value may change as the operation progresses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cancelable", Required = Required.AllowNull)]
        public bool Cancelable { get; set; }
        /// <summary>
        /// Description of the error if the operation status is "FAILED".
        /// If unset the description of why the operation failed will be included in the result of the operation (see Info.result).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Time when the operation is started.
        /// This field is optional and it is only relevant when the value of CommonInfo.status is one of RUNNING, BLOCKED,
        /// SUCCEEDED, or FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Time when the operation is completed.
        /// This field is optional and it is only relevant when the value of CommonInfo.status is one of SUCCEEDED or FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// Name of the user who performed the operation.
        /// This field will be unset if the operation is performed by the system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
    }
}
