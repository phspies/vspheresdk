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
    public class VcenterGuestCustomizationSpecsCreateTypeA 
    {
        /// <summary>
        /// The information i.e. name, description and the settings i.e hostname, ip address etc for the new customization
        /// specification that needs to be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterGuestCustomizationSpecsCreateSpecTypeA Spec { get; set; }
    }
}
