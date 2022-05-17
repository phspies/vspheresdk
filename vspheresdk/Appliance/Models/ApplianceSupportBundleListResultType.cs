using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceSupportBundleListResultType 
    {
        /// <summary>
        /// Information about all support bundle requests.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supportbundle_operations", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceSupportBundleInfoType> SupportbundleOperations { get; set; }
    }
}
