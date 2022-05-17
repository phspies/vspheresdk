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
    public class VcenterGuestCustomizationSpecsExportType 
    {
        /// <summary>
        /// The format in which the customization specification has to be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "format", Required = Required.AllowNull)]
        public VcenterGuestCustomizationSpecsFormatEnumType Format { get; set; }
    }
}
