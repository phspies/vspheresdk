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
    public class CisTasksGetSpecTypeA 
    {
        /// <summary>
        /// If true, all data, including operation-specific data, will be returned, otherwise only the data described in Info will
        /// be returned.
        /// If unset, only the data described in Info will be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "return_all")]
        public bool? ReturnAll { get; set; }
        /// <summary>
        /// If true, the result will not be included in the task information, otherwise it will be included.
        /// If unset, the result of the operation will be included in the task information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "exclude_result")]
        public bool? ExcludeResult { get; set; }
    }
}
