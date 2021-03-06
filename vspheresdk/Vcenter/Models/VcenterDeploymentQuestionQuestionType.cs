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
    public class VcenterDeploymentQuestionQuestionType 
    {
        /// <summary>
        /// Id of the question raised.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// Message describing the question.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "question", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Question { get; set; }
        /// <summary>
        /// Type of the question raised.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterDeploymentQuestionQuestionTypeEnum Type { get; set; }
        /// <summary>
        /// Default answer value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_answer", Required = Required.AllowNull)]
        public string DefaultAnswer { get; set; }
        /// <summary>
        /// Possible answers values.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "possible_answers", Required = Required.AllowNull)]
        public IList<string> PossibleAnswers { get; set; }
    }
}
