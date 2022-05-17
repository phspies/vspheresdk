using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiRestNavigationRootInfoType 
    {
        /// <summary>
        /// Link to component list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components", Required = Required.AllowNull)]
        public VapiRestNavigationLinkType Components { get; set; }
        /// <summary>
        /// Link to resource list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resources", Required = Required.AllowNull)]
        public VapiRestNavigationLinkType Resources { get; set; }
    }
}
