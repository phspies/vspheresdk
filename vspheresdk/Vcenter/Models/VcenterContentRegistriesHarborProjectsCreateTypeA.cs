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
    public class VcenterContentRegistriesHarborProjectsCreateTypeA 
    {
        /// <summary>
        /// Information used to create the Harbor project.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterContentRegistriesHarborProjectsCreateSpecTypeA Spec { get; set; }
    }
}
