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
    public class ApplianceRecoveryBackupJobDetailsInfoTypeA 
    {
        /// <summary>
        /// URL of the backup location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Time in seconds since the backup job was started or the time it took to complete the backup job.
        /// This field is optional and it is only relevant when the value of CommonInfo#status is one of SUCCEEDED, FAILED, or
        /// RUNNING.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }
        /// <summary>
        /// Size of the backup data transferred to remote location.
        /// This field is optional and it is only relevant when the value of CommonInfo#status is one of SUCCEEDED, FAILED, or
        /// RUNNING.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// Progress of the job.
        /// This field is optional and it is only relevant when the value of CommonInfo#status is one of SUCCEEDED, FAILED, or
        /// RUNNING.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public CisTaskProgressTypeA Progress { get; set; }
        /// <summary>
        /// The username for the remote backup location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_user", Required = Required.AllowNull)]
        public string LocationUser { get; set; }
        /// <summary>
        /// Type of the backup job. Indicates whether the backup was started manually or as a scheduled backup.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupJobDetailsTypeEnumA Type { get; set; }
        /// <summary>
        /// List of any info/warning/error messages returned by the backup job.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageTypeA> Messages { get; set; }
        /// <summary>
        /// Information about the build of the appliance.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "build")]
        public ApplianceRecoveryBackupJobDetailsBuildInfoTypeA Build { get; set; }
        /// <summary>
        /// Description of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageTypeA Description { get; set; }
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
        public VapiStdDynamicIdtypeA Target { get; set; }
        /// <summary>
        /// Status of the operation associated with the task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public CisTaskStatusEnumTypeA Status { get; set; }
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
