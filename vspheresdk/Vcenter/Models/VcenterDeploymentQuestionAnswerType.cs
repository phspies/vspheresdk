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
    public class VcenterDeploymentQuestionAnswerType 
    {
        /// <summary>
        /// Id of the question being answered.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "question_id", Required = Required.AllowNull)]
        public string QuestionId { get; set; }
        /// <summary>
        /// The answer value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "answer_val", Required = Required.AllowNull)]
        public string AnswerVal { get; set; }
    }
}
