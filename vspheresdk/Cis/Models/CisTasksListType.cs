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
    public class CisTasksListType 
    {
        /// <summary>
        /// Specification of matching tasks.
        /// This is currently required. In the future, if it is unset, the behavior is equivalent to a Tasks.FilterSpec with all
        /// fields unset which means all tasks match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "filter_spec")]
        public CisTasksFilterSpecType FilterSpec { get; set; }
        /// <summary>
        /// Specification of what to return for a task.
        /// If unset, the behavior is equivalent to a Tasks.GetSpec with all fields unset which means only the data describe in Info
        /// will be returned and the result of the operation will be return.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "result_spec")]
        public CisTasksGetSpecType ResultSpec { get; set; }
    }
}
