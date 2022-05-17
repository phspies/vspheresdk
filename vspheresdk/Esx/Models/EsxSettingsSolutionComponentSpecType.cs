using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsSolutionComponentSpecType 
    {
        /// <summary>
        /// Identifier of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "component", Required = Required.AllowNull)]
        public string Component { get; set; }
    }
}
