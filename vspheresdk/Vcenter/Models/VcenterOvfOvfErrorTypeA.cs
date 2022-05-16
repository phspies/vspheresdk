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
    public class VcenterOvfOvfErrorTypeA 
    {
        /// <summary>
        /// The message category.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public VcenterOvfOvfMessageCategoryTypeA Category { get; set; }
        /// <summary>
        /// {@term List} of parse issues (see {@link ParseIssue}).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issues")]
        public Dictionary<string,VcenterOvfParseIssueTypeA> Issues { get; set; }
        /// <summary>
        /// The name of input parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The value of input parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string? Value { get; set; }
        /// <summary>
        /// A localizable message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public VapiStdLocalizableMessageTypeA Message { get; set; }
        /// <summary>
        /// Represents a server {@link Error}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public object Error { get; set; }
    }
}