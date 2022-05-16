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
    public class VcenterDeploymentQuestionInfoType 
    {
        /// <summary>
        /// One or more questions raised during the deployment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "questions", Required = Required.AllowNull)]
        public Dictionary<string,VcenterDeploymentQuestionQuestionType> Questions { get; set; }
    }
}
