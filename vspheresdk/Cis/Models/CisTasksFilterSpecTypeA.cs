using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Models
{
    public class CisTasksFilterSpecTypeA 
    {
        /// <summary>
        /// Identifiers of tasks that can match the filter.
        /// This field may be unset if Tasks.FilterSpec.services is specified. Currently all tasks must be from the same provider.
        /// If unset or empty, tasks with any identifier will match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// cis.task. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: cis.task.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tasks")]
        public IList<string> Tasks { get; set; }
        /// <summary>
        /// Identifiers of services. Tasks created by operations in these services match the filter (see CommonInfo.service).
        /// This field may be unset if Tasks.FilterSpec.tasks is specified. Currently all services must be from the same provider.
        /// If this field is unset or empty, tasks for any service will match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vapi.service. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: vapi.service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// Identifiers of operations. Tasks created by these operations match the filter (see CommonInfo.operation).
        /// Note that an operation identifier by itself is not globally unique. To filter on an operation, the identifier of the
        /// service interface containing the operation should also be specified in Tasks.FilterSpec.services.
        /// 
        /// If unset or empty, tasks associated with any operation will match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vapi.operation. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: vapi.operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations")]
        public IList<string> Operations { get; set; }
        /// <summary>
        /// Status that a task must have to match the filter (see CommonInfo.status).
        /// If unset or empty, tasks with any status match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Dictionary<string,CisTaskStatusEnumTypeA> Status { get; set; }
        /// <summary>
        /// Identifiers of the targets the operation for the associated task created or was performed on (see CommonInfo.target).
        /// If unset or empty, tasks associated with operations on any target match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "targets")]
        public Dictionary<string,VapiStdDynamicIdtypeA> Targets { get; set; }
        /// <summary>
        /// Users who must have initiated the operation for the associated task to match the filter (see CommonInfo.user).
        /// If unset or empty, tasks associated with operations initiated by any user match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<string> Users { get; set; }
    }
}
