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
    public class VcenterHvcLinksCreateType 
    {
        /// <summary>
        /// Specification for the new link to be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterHvcLinksCreateSpecType Spec { get; set; }
    }
}