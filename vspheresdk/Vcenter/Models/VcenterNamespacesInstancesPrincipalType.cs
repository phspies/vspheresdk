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
    public class VcenterNamespacesInstancesPrincipalType 
    {
        /// <summary>
        /// Name of the subject.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject", Required = Required.AllowNull)]
        public string Subject { get; set; }
        /// <summary>
        /// Domain of the subject.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain", Required = Required.AllowNull)]
        public string Domain { get; set; }
    }
}
