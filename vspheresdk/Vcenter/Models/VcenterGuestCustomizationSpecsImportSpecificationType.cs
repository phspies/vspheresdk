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
    public class VcenterGuestCustomizationSpecsImportSpecificationType 
    {
        /// <summary>
        /// content to be converted to the spec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "customization_spec", Required = Required.AllowNull)]
        public string CustomizationSpec { get; set; }
    }
}
