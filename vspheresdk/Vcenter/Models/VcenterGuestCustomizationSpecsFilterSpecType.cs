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
    public class VcenterGuestCustomizationSpecsFilterSpecType 
    {
        /// <summary>
        /// Names that guest customization specifications must have to match the filter (see CustomizationSpecs.Summary.name).
        /// If unset or empty, guest customization specifications with any name match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.guest.CustomizationSpec. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.guest.CustomizationSpec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Guest operating system type that guest customization specifications must have to match the filter (see
        /// CustomizationSpecs.Summary.os-type).
        /// If unset, guest customization specifications with any guest operating system type match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "OS_type")]
        public VcenterGuestCustomizationSpecsOsTypeEnum OStype { get; set; }
    }
}
